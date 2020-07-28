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
        private string semester;
        private int final;

        public Task(string courseCode, double courseWeight, string taskName, double taskMark, double taskWeight, string semester, int final)
        {
            this.courseCode = courseCode;
            this.courseWeight = courseWeight;
            this.taskName = taskName;
            this.taskMark = taskMark;
            this.taskWeight = taskWeight;
            this.semester = semester;
            this.final = final;
        }

        public Task(string courseCode, double courseWeight, string taskName, double taskWeight, string semester, int final)
        {
            this.courseCode = courseCode;
            this.courseWeight = courseWeight;
            this.taskName = taskName;
            this.taskMark = 0.0;
            this.taskWeight = taskWeight;
            this.semester = semester;
            this.final = final;
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
            set { this.taskName = value; }
        }

        public double TaskMark
        {
            get { return this.taskMark; }
            set { this.taskMark = value; }
        }

        public double TaskWeight
        {
            get { return this.taskWeight; }
            set { this.taskWeight = value; }
        }

        public string Semester
        {
            get { return this.semester; }
            set { this.semester = value; }
        }

        public int Final
        {
            get { return this.final; }
            set { this.final = value; }
        }
    }
}
