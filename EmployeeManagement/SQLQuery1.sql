create table Salary
(
  SalaryId int primary key identity,
  EmployeeId int,
  EmployeeName varchar(255),
  JobDescription varchar(200),
  Month varchar(10),
  EmployeeSalary int
)

select * from Employee_Payroll
select * from Salary

insert into Salary values(1,'Rye','HR','Jan',12000)
insert into Salary values(1,'Rye','HR','Feb',13000)
insert into Salary values(1,'Rye','HR','March',14000)

create procedure SpUpdateEmployeeSalary
(
@id int,
@month varchar(10),
@salary int,
@empId int
)
as 
begin
    Update Salary
	set EmployeeSalary=@salary where SalaryId=@id and Month=@month and EmployeeId=@empId
	select e.EmployeeId,e.EmployeeName, s.JobDescription,s.EmployeeSalary,s.Month,s.SalaryId
	from Employee_Payroll e inner join Salary s on e.EmployeeId=s.EmployeeId where s.SalaryId=@id
end








