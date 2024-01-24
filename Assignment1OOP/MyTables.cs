using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1OOP
{
    enum County{
        Antrim,
        Armagh,
        Carlow,
        Cavan,
        Clare,
        Cork,
        Derry,
        Donegal,
        Down,
        Dublin,
        Fermanagh,
        Galway,
        Kerry,
        Kildare,
        Kilkenny,
        Laois,
        Leitrim,
        Limerick,
        Longford,
        Louth,
        Mayo,
        Meath,
        Monaghan,
        Offaly,
        Roscommon,
        Sligo,
        Tipperary,
        Tyrone,
        Waterford,
        Westmeath,
        Wexford,
        Wicklow
    }

    enum Courses
    {
        Computing, 
        Law,
        Business,
        Marketing
    }

    enum Students
    {
        ByGender,
        ByCourse,
        ByAge
    }
    enum Lecturers
    {
        ByGender,
        ByCourse
    }

    enum Age
    {
        Above25,
        Below25
    }

    enum Gender
    {
        Male,
        Female
    }

    enum Grades
    {
        Sufficient,
        Insufficient,
        LowToHigh,
        HighToLow
    }

    enum Computing
    {
        ProgrammingFundamentals,
        WebDevelopment,
        CloudComputing,
        OOP,
        ComputerArchitecture
    }

    enum Marketing
    {
        Introduction,
        DigitalContext,
        MktStrategys,
        Communication,
        BusinessLaw
    }

    enum Law
    {
        Contract,
        Criminal,
        Constitutional,
        Jurisprudence,
        LandLaw
    }

    enum Business
    {
        Analytics,
        BrandManagement,
        CorporateFinance,
        Accounting,
        DigitalMkt
    }
}
