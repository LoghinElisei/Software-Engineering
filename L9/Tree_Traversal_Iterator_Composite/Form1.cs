using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Tree_Traversal_Iterator_Composite.Iterators;
using Tree_Traversal_Iterator_Composite.Models;

namespace Tree_Traversal_Iterator_Composite
{
    public partial class Form1 : Form
    {
        private ProjectTask _projectRoot;

        public Form1()
        {
            InitializeComponent();

            InitializeMockData();
        }

        private void InitializeMockData()
        {
            _projectRoot = new ProjectTask("Project Root", "Root node of the project", 0, 0);

            var planning = new ProjectTask("Planning", "Initial planning activities", 5, 2000);
            planning.Add(new ProjectTask("Requirements Gathering", "Collect user and system requirements", 3, 1200));
            planning.Add(new ProjectTask("Timeline Creation", "Draft overall timeline for project phases", 2, 800));

            var implementation = new ProjectTask("Implementation", "Development phase", 10, 8000);
            implementation.Add(new ProjectTask("Frontend", "UI/UX implementation", 5, 4000));
            implementation.Add(new ProjectTask("Backend", "Business logic and database development", 5, 4000));

            var testing = new ProjectTask("Testing", "Ensure code quality", 4, 1500);

            var unit_testing = new ProjectTask("Unit Testing", "Perform unit tests on modules",4,1500);
          
            _projectRoot.Add(planning);
            _projectRoot.Add(implementation);
            _projectRoot.Add(testing);
            _projectRoot.Add(unit_testing);

            RefreshTreeView();
        }

        private void RefreshTreeView()
        {
            treeViewProject.Nodes.Clear();
            var rootNode = CreateTreeNode(_projectRoot);
            treeViewProject.Nodes.Add(rootNode);
            treeViewProject.ExpandAll();
        }

        private TreeNode CreateTreeNode(ProjectComponent component)
        {
            var node = new TreeNode(component.Name)
            {
                Tag = component 
            };

            if (component is ProjectTask task)
            {
                foreach (var child in task.SubTasks)
                {
                    node.Nodes.Add(CreateTreeNode(child));
                }
            }
            return node;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (treeViewProject.SelectedNode == null)
            {
                MessageBox.Show("Vă rugăm să selectați o sarcină părinte din arbore pentru a adăuga.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text)) return;

            int.TryParse(txtDuration.Text, out int duration);
            decimal.TryParse(txtCost.Text, out decimal cost);

            var newTask = new ProjectTask(txtName.Text, txtDescription.Text, duration, cost);

            var parentTask = (ProjectTask)treeViewProject.SelectedNode.Tag;
            parentTask.Add(newTask);

            RefreshTreeView();

            txtName.Clear(); txtDescription.Clear(); txtDuration.Clear(); txtCost.Clear();
        }

        private void btnDFS_Click_1(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            listBoxOutput.Items.Add("--- Parcurgere DFS ---");

            IProjectIterator dfs = new DFSIterator(_projectRoot);
            while (dfs.MoveNext())
            {
                var task = dfs.Current;
                listBoxOutput.Items.Add($"- {task.Name} ({task.Duration} zile, {task.Cost} USD)");
            }

            DisplayTotals();
        }

        private void btnBFS_Click_1(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            listBoxOutput.Items.Add("--- Parcurgere BFS ---");

            IProjectIterator bfs = new BFSIterator(_projectRoot);
            while (bfs.MoveNext())
            {
                var task = bfs.Current;
                listBoxOutput.Items.Add($"- {task.Name} ({task.Duration} zile, {task.Cost} USD)");
            }

            DisplayTotals();
        }

        private void DisplayTotals()
        {
            listBoxOutput.Items.Add("");
            listBoxOutput.Items.Add($"--- DURATA TOTALĂ PROIECT: {_projectRoot.GetTotalDuration()} zile ---");
            listBoxOutput.Items.Add($"--- COST TOTAL PROIECT: {_projectRoot.GetTotalCost()} USD ---");
        }

     
    }
}
