using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw4_1 {
    public partial class Form1 : Form {
        private Graphics graphics;
        Pen[] pens = { Pens.Black, Pens.Blue, Pens.Red, Pens.Green, Pens.Purple };

        private void drawOnPanel(int penNum, int x0, int y0, int x1, int y1, int x2, int y2) {
            graphics.DrawLine(pens[penNum], new Point(x0, y0), new Point(x1, y1));
            graphics.DrawLine(pens[penNum], new Point(x0, y0), new Point(x2, y2));
        }
        
        public Form1() {
            InitializeComponent();
            graphics = drawPanel.CreateGraphics();
        }

        private CayleyTree initTree(string recursionDeepth, string mainBranchLength, string rightLenthPer,
            string leftLenthPer, string rightAngle, string leftAngle) {
            int Deepth = int.Parse(recursionDeepth);
            int Length = int.Parse(mainBranchLength);
            double rightPer = double.Parse(rightLenthPer);
            double leftPer = double.Parse(leftLenthPer);
            double rAngle = double.Parse(rightAngle) * Math.PI / 180;
            double lAngle = double.Parse(leftAngle) * Math.PI / 180;

            CayleyTree tree = new CayleyTree(Deepth, Length, rightPer, leftPer, rAngle, lAngle);
            return tree;
        }

        public void DrawCayleyTree(int x0, int y0, CayleyTree tree, int colorNum, double th) {
            if (tree.recursionDeepth == 0) return;
            int x1 = Convert.ToInt32(x0 + tree.mainBranchLength * Math.Cos(tree.leftAngle));
            int y1 = Convert.ToInt32(y0 + tree.mainBranchLength * Math.Sin(tree.leftAngle));

            int x2 = Convert.ToInt32(x0 + tree.mainBranchLength * Math.Cos(tree.rightAngle));
            int y2 = Convert.ToInt32(y0 + tree.mainBranchLength * Math.Sin(tree.rightAngle));

            switch (colorNum) {
                case 0: drawOnPanel(0, x0, y0, x1, y1, x2, y2); break;
                case 1: drawOnPanel(1, x0, y0, x1, y1, x2, y2); break;
                case 2: drawOnPanel(2, x0, y0, x1, y1, x2, y2); break;
                case 3: drawOnPanel(3, x0, y0, x1, y1, x2, y2); break;
                case 4: drawOnPanel(4, x0, y0, x1, y1, x2, y2); break;
            }

            int newRecursionDeepth = tree.recursionDeepth - 1;
            int newLeftBranchLength = Convert.ToInt32(tree.mainBranchLength * tree.leftLenthPer);
            int newRightBranchLength = Convert.ToInt32(tree.mainBranchLength * tree.rightLenthPer);
            double newRightPer = tree.rightLenthPer;
            double newLeftPer = tree.leftLenthPer;
            double newLeftAngle = th + tree.leftAngle;
            double newRightAngle = th - tree.rightAngle;

            CayleyTree leftTree = new CayleyTree(newRecursionDeepth, newLeftBranchLength, newRightPer, 
                newLeftPer, newRightAngle, newLeftAngle);
            CayleyTree rightTree = new CayleyTree(newRecursionDeepth, newRightBranchLength, newRightPer,
               newLeftPer, newRightAngle, newLeftAngle);

            DrawCayleyTree(x1, y1, leftTree, colorNum, th);
            DrawCayleyTree(x2, y2, rightTree, colorNum, th);
        }

        private void drawButton_Click(object sender, EventArgs e) {
            graphics.Clear(BackColor);
            graphics = drawPanel.CreateGraphics();
            string branchLength = mainBranchText.Text;
            string deepth = recursionDeepthText.Text;
            string leftPer = leftPerText.Text;
            string rightPer = rightPerText.Text;
            string rAngle = rightAngleText.Text;
            string lAngle = leftAngleText.Text;
            int colorNum = penColorList.SelectedIndex;

            CayleyTree tree = initTree(deepth, branchLength, rightPer, leftPer, rAngle, lAngle);
            DrawCayleyTree(drawPanel.Right / 2, drawPanel.Top, tree, colorNum, Math.PI / 2);
        }
    }
}
