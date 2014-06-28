using System;

namespace T4FluentNH.Attributes
{
    //nhiberante will create a many to one relation but in code the .tt template will generate a one to one relation (in nhibernate one to one on same type will throw an stackoverflow exception!)
    //this attribute is only relevant to .tt template
    public class AsOneToOneAttribute : Attribute
    {
    }
}
