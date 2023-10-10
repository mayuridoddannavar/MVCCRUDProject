namespace MVCCRUDProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployeeData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Employees(EmployeeName,EmployeeDesignation,EmployeeAddress,EmployeePassport,EmployeePhone,EmployeeGender,City,Project,CompanyName,PinCode,DepartmentId)" +
                "Values('Mayuri','Solution Developer','Pune','Mayu1234',9876543210,'Female','Pune','Developer','Tata Technologies',411057,1)");
        }
        
        public override void Down()
        {
        }
    }
}
