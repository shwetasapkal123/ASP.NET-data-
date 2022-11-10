class EmployeePayrollData
{
    id;
    salary;

    constructor (id, name, salary)
    {
        this.id=id;
        this.name=name;
        this.salary=salary;
    }

    get salary(){ return this.salary;}
    set salary(n){this.salary=n}

    toString()
    {
        return "id "+this.id+" ,name "+this.name+" ,salary "+this.salary;
    }

}

let employeePayrollData=new EmployeePayrollData(1,"Mark",30000);
console.log(employeePayrollData.toString());
employeePayrollData.salary=2030;
console.log(employeePayrollData.toString());