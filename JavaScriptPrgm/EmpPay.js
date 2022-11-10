/* UC1 check employee present absent*/
/*let empCheck=Math.floor(Math.random()*10)%2;
console.log(Math.random()*10);
console.log(Math.floor(Math.random()*10));
console.log(Math.floor(Math.random()*10)%2);

if(empCheck==0)
{
    console.log("Employee absent");
}
else{
    console.log("Employee present");
}*/

/*UC2 - Using switch case calculate employee wage for day*/
const IS_PART_TIME=1;
const IS_FULL_TIME=2;
const PART_TIME_HOURS=4;
const FULL_TIME_HOURS=8;
const WAGE_PER_HOUR=20;
let empHrs=0;
//UC-3
function getWorkingHours(empCheck)
{
    switch(empCheck)
    {
        case IS_PART_TIME:
            //empHrs=PART_TIME_HOURS;
            return  PART_TIME_HOURS;
            case IS_FULL_TIME:
                //empHrs=FULL_TIME_HOURS;
                return FULL_TIME_HOURS;
                default:return 0;
    }
}

function calcdailyWage(empHrs)
{
   return empHrs*WAGE_PER_HOUR;
}

const MAX_HRS_IN_MONTH=160;
const NUM_OF_WORKING_DAYS=20;
let totalEmpHrs=0;
let totalWorkingDays=0;
let empDailyWageArr=new Array();
let empDailywageMap=new Map();

while(totalEmpHrs<=MAX_HRS_IN_MONTH && totalWorkingDays<NUM_OF_WORKING_DAYS)
{
    totalWorkingDays++;
    let empCheck=Math.floor(Math.random()*10)%3;
    empHrs+=getWorkingHours(empCheck);
    totalEmpHrs+=empHrs;
    empDailyWageArr.push(
        {
            dayNum:totalWorkingDays,
            dailyHrs:empHrs,
            dailyWage:calcdailyWage(empHrs),

            toString()
            {
                return "Day "+this.dayNum+" =>working hours is "+this.dailyHrs+" And wage earned "+this.dailyWage
            },
        }
    );
    //empDailyWageArr.push(calcdailyWage(empHrs));
    empDailywageMap.set(totalWorkingDays,calcdailyWage(empHrs));
}
//console.log(empDailywageMap);
console.log("UC showing daily hours worked and wage earned "+empDailyWageArr);
function totalWage(totalWage,dailyWage)
{
    return totalWage+dailyWage;
}

console.log("UC 8-Emp wage map total hrs "+Array.from(empDailywageMap.values()).reduce(totalWage,0));
//console.log("UC-5 total days: "+totalWorkingDays+"  total emp hrs: "+totalEmpHrs+"  Emp wage: "+empWage);

const findTotal=(totalVal,dailyval)=>
{
    return totalVal+dailyval;
}

let count=0;
let totalHours=Array.from(empDailywageMap.values()).reduce(findTotal,0);
let totalSalary=empDailyWageArr.filter(dailyWage=>dailyWage>0).reduce(findTotal,0);

let nonWorkingDays=new Array();
let partWorkingDays=new Array();
let fullWorkingDays=new Array();

empDailyWageArr.forEach((value,key,map)=>
{
    if(value==160)fullWorkingDays.push(key);
    else if(value==80) partWorkingDays.push(key);
    else nonWorkingDays.push(key);
});

console.log("Full working Days: "+fullWorkingDays);
console.log("Part working Days: "+partWorkingDays);
console.log("Non working Days: "+nonWorkingDays);

