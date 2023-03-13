using ExpertSystemShell.Components;
using ExpertSystemShell.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExpertSystemShell.UI
{
    public partial class ExplanationForm : Form
    {
        private readonly WorkingMemory _memory;
        private bool treeHidden = true;

        public ExplanationForm(WorkingMemory memory)
        {
            InitializeComponent();
            _memory = memory;
            InitiailizeTreeView();
            InitializeVariablesPanel();
        }

        private void InitiailizeTreeView()
        {
            labelHideTree.Text = "(раскрыть всё)";
            BuildTree(null, _memory.ProvenFacts.Peek());
        }

        private TreeNode AddTreeNode(TreeNode parentNode, string text, List<Fact> tagFacts)
        {
            TreeNode node = parentNode == null? treeView.Nodes.Add(text) : parentNode.Nodes.Add(text);
            node.Tag = tagFacts;
            return node;
        }

        private void BuildTree(TreeNode node, Fact fact)
        {
            if (fact.Variable.Type == EVariableType.Inferable)
            {
                node = AddTreeNode(node, $"Цель: {fact}", new List<Fact> { fact });
            }
            else
            {
                if (fact.Variable.Type == EVariableType.Requested || 
                    fact.Variable.Type == EVariableType.InferredRequested &&
                    _memory.TriggeredRules.FirstOrDefault(
                        r => r.Inferences.Exists(f => f.Variable == fact.Variable)) == null) 
                {

                    AddTreeNode(node, $"Цель: {fact} (запрошено у пользователя)", new List<Fact> { fact });
                    return;
                }
                else
                {
                    node = AddTreeNode(node, $"Цель: {fact}", new List<Fact> { fact });
                }
            }

            Rule triggeredRule = _memory.TriggeredRules.FirstOrDefault(
                r => r.ContainsVariableInInference(fact.Variable));
            node = AddTreeNode(node, $"[{triggeredRule.Name}] {triggeredRule}",
                triggeredRule.Premises.Union(triggeredRule.Inferences).ToList());
            foreach (var f in triggeredRule.Premises)
            {
                BuildTree(node, f);
            }

        }

        private void InitializeVariablesPanel()
        {
            lstViewVariables.FullRowSelect = true;
            lstViewVariables.HideSelection = false;
            lstViewVariables.Items.Clear();
            foreach (var fact in _memory.ProvenFacts)
            {
                lstViewVariables.Items.Add(new ListViewItem(new string[]
                {
                    fact.Variable.Name,
                    fact.Value.Value
                }));
            }
        }

        private void labelHideTree_Click(object sender, System.EventArgs e)
        {
            treeHidden = !treeHidden;
            if (!treeHidden)
            {
                treeView.Nodes[0].ExpandAll();
                labelHideTree.Text = "(скрыть всё)";
            }
            else
            {
                treeView.Nodes[0].Collapse();
                labelHideTree.Text = "(раскрыть всё)";
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var varsForSelect = ((List<Fact>)treeView.SelectedNode.Tag).Select(f => f.Variable).ToList();
            foreach (ListViewItem variable in lstViewVariables.Items)
            {
                variable.Selected = varsForSelect.Exists(v => v.Name == variable.Text);
            }
        }

        private void treeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            treeView.SelectedNode = treeView.TopNode;
        }
    }
}
