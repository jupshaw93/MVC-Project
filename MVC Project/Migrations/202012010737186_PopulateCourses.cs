namespace MVC_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCourses : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses(CourseName, CourseDescription, TutorName, CourseRating) VALUES ('Physics', 'Understanding Physics', 'MrJames', 4)");
            Sql("INSERT INTO Courses(CourseName, CourseDescription, TutorName, CourseRating) VALUES ('Civics', 'Understanding Civics', 'MrJames', 4)");
            Sql("INSERT INTO Courses(CourseName, CourseDescription, TutorName, CourseRating) VALUES ('Geography', 'Understanding the Physical World', 'MrJames', 4)");
            Sql("INSERT INTO Courses(CourseName, CourseDescription, TutorName, CourseRating) VALUES ('Creative Writing', 'Learning self expression through your words', 'MrJames', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
