const company=new Object();
company.name='Bridgelab';
company.location='mumbai';
company.headquarter='mumbai';

company.displayInformation=function()
{
    console.log(company.name+"  "+company.headquarter+"  "+company.location);
}

company.displayInformation();