//
// Disciplina: Algoritmos em Grafos
// *Discipline: Algorithms in Graphs
// Igor Octaviano
// https://github.com/igoroctaviano
//
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

using PathFinder_501119.Algorithms;
using PathFinder_501119.Structure;

namespace PathFinder_501119
{
    public partial class Menu : Form
    {
        private const int MAP_SIZE = 11;
        private Map map;

        private AStar aStar;

        private Button[,] buttons;
        private Stopwatch stopWatch;

        public Menu()
        {
            InitializeComponent();

            // Initialize search algorithms.
            this.aStar = new AStar();

            // Initialize components.
            this.stopWatch = new Stopwatch();

            // Fill the panel
            // then connect the panel to map system.
            this.buttons = new Button[MAP_SIZE, MAP_SIZE];
            this.FillFlowLayoutPanel();
            this.map = new Map(this.flowLayoutPanel, this.buttons);

            // Init components.
            this.Init();
        }

        private void Init()
        {
            // Start buttons.
            this.buttonClear.Enabled = false;
            this.buttonReset.Enabled = false;

            // Start labels.
            this.labelCounterAStar.Text = "0";
            this.LabelCompletedTime.Text = "Tempo " + 0 + " sec.";

            // Start combobox with default values.
            this.comboBoxHeuristicType.SelectedIndex = 0;

            // Reset map.
            this.map.Reset();
        }

        private void StartTimer()
        {
            // Refresh timer label.
            this.LabelCompletedTime.Text = "Tempo " + 0 + " sec.";

            // Start clock.
            this.stopWatch.Start();
        }

        private void StopTimer()
        {
            // Stop clock.
            this.stopWatch.Stop();
            string timeSpent = this.stopWatch.Elapsed.ToString();

            // Refresh timer label.
            this.LabelCompletedTime.Text = "Tempo " + timeSpent + " sec.";

            // Reset timer.
            this.stopWatch.Reset();
        }

        private void Run()
        {
            this.StartTimer();

            // Set delay.
            this.map.Delay = (int)Math.Pow(this.BarDelay.Value, 2);

            // Set heuristic formula.
            this.aStar.Formula = (HeuristicFormula)this.comboBoxHeuristicType.SelectedIndex;
            ArrayList solution = this.aStar.GetSolutionPath();
            ArrayList ignoredSolution = this.aStar.IgnoredSolutionPath;
            this.map.PrintSolution(solution, ignoredSolution);
            int movements = (this.aStar.IgnoredSolutionPath.Count);
            this.labelCounterAStar.Text = movements.ToString();

            this.StopTimer();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            this.ButtonStart.Enabled = false;
            this.Run();

            this.buttonClear.Enabled = true;
            this.buttonReset.Enabled = true;

            this.comboBoxHeuristicType.Enabled = false;
        }

        private void FillFlowLayoutPanel()
        {
            const int BUTTON_SIZE = 32;

            // Clear the flow panel.
            this.flowLayoutPanel.Controls.Clear();

            // Fill the flow panel with buttons.          
            for (int x = 0; x < MAP_SIZE; x++) 
            {
                for (int y = 0; y < MAP_SIZE; y++)
                {
                    this.buttons[x, y] = new Button();
                    this.buttons[x, y].Width = BUTTON_SIZE;
                    this.buttons[x, y].Height = BUTTON_SIZE;
                    this.buttons[x, y].BackColor = Color.White;
                    this.buttons[x, y].Tag = (x + "-" + y); // Tag.
                    this.buttons[x, y].Click += new EventHandler(ButtonClickAction); // Add click function.
                    this.flowLayoutPanel.Controls.Add(this.buttons[x, y]);
                }
            }   

            // Color the start and the goal button
            this.buttons[0, 0].BackColor = Color.Gold;
            this.buttons[MAP_SIZE - 1, MAP_SIZE - 1].BackColor = Color.Gold;
        }

        private void ButtonClickAction(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Get the button tag.
            string buttonTag = button.Tag.ToString();
            string[] splitter = buttonTag.Split('-');

            // Get column and row from tag.
            int x = int.Parse(splitter[0]);
            int y = int.Parse(splitter[1]);

            // Activate reset button to permit remove this wall.
            this.buttonReset.Enabled = true;

            // Insert the wall.
            this.map.InsertWall(x, y);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.ButtonStart.Enabled = true;

            this.map.ClearSolution();

            // Disable clear button.
            this.buttonClear.Enabled = false;

            this.comboBoxHeuristicType.Enabled = true;

            this.comboBoxHeuristicType.SelectedIndex = 0;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Enable start button.
            this.ButtonStart.Enabled = true;

            // Reset elements.
            this.Init();

            this.buttonClear.Enabled = false;
            this.buttonReset.Enabled = false;

            this.comboBoxHeuristicType.Enabled = true;
        }

        private void Menu_Load(object sender, EventArgs e) { }
        private void BarDelay_Scroll(object sender, EventArgs e) { }
        private void LabelDelay_Click(object sender, EventArgs e) { }
        private void labelAStar_Click(object sender, EventArgs e) { }
        private void labelBreadth_Click(object sender, EventArgs e) { }
        private void LabelCompletedTime_Click(object sender, EventArgs e) { }
        private void labelMovementsAStar_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e) { }
        private void comboBoxHeuristicType_SelectedIndexChanged(object sender, EventArgs e) { }
        private void labelCounterAStar_Click(object sender, EventArgs e) { }
    }
}
