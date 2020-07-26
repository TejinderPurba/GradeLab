using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTrackerV3
{
    public class Task
    {
        private string courseCode;
        private double courseWeight;
        private string taskName;
        private double taskMark;
        private double taskWeight;

        public Task(string courseCode, double courseWeight, string taskName, double taskMark, double taskWeight)
        {
            this.courseCode = courseCode;
            this.courseWeight = courseWeight;
            this.taskName = taskName;
            this.taskMark = taskMark;
            this.taskWeight = taskWeight;
        }

        public Task(string courseCode, double courseWeight, string taskName, double taskWeight)
        {
            this.courseCode = courseCode;
            this.courseWeight = courseWeight;
            this.taskName = taskName;
            this.taskMark = 0.0;
            this.taskWeight = taskWeight;
        }

        public Task()
        {

        }

        public string CourseCode
        {
            get { return this.courseCode; }
            set { this.courseCode = value; }
        }

        public double CourseWeight
        {
            get { return this.courseWeight; }
            set { this.courseWeight = value; }
        }

        public string TaskName
        {
            get { return this.taskName; }
            set { taskName = value; }
        }

        public double TaskMark
        {
            get { return this.taskMark; }
            set { taskMark = value; }
        }

        public double TaskWeight
        {
            get { return this.taskWeight; }
            set { taskWeight = value; }
        }
    }
}
