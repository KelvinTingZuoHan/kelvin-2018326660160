using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_1 {
    public class CayleyTree {
        public int recursionDeepth, mainBranchLength, leftBranchLength, rightBranchLength;
        public double rightLenthPer, leftLenthPer, rightAngle, leftAngle;

        public CayleyTree(int recursionDeepth, int mainBranchLength, double rightLenthPer, 
            double leftLenthPer, double rightAngle, double leftAngle) {
            this.recursionDeepth = recursionDeepth;
            this.mainBranchLength = mainBranchLength;
            this.leftLenthPer = leftLenthPer;
            this.rightLenthPer = rightLenthPer;
            this.rightAngle = rightAngle;
            this.leftAngle = leftAngle;
        }
    }
}
