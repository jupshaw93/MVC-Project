namespace MVC_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStudent : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Students (FirstName, LastName, CourseId, CourseEnrolledDate, CourseStatus, Grade) VALUES ('Trina', 'Jones', 101, convert(datetime, 2020-05-06), 98, 'A' )");
            Sql("INSERT INTO Students (FirstName, LastName, CourseId, CourseEnrolledDate, CourseStatus, Grade) VALUES ('Clint', 'Walker', 101, convert(datetime, 2020-05-06), 75, 'C' )");
            Sql("INSERT INTO Students (FirstName, LastName, CourseId, CourseEnrolledDate, CourseStatus, Grade) VALUES ('Karen', 'Brooks', 101, convert(datetime, 2020-05-06), 89, 'B' )");
            Sql("INSERT INTO Students (FirstName, LastName, CourseId, CourseEnrolledDate, CourseStatus, Grade) VALUES ('Vivian', 'Lee', 101, convert(datetime, 2020-05-06), 90, 'A' )");
            Sql("INSERT INTO Students (FirstName, LastName, CourseId, CourseEnrolledDate, CourseStatus, Grade) VALUES ('Damon', 'Ray', 101, convert(datetime, 2020-05-06), 80, 'B' )");
        }
        
        public override void Down()
        {
        }
    }
}
