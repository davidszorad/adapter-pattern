using System;

namespace AdapterPattern
{
    /*
    This real-world code demonstrates the use of a legacy chemical databank. 
    Chemical compound objects access the databank through an Adapter interface. 

    
    The classes and objects participating in this pattern are:

    Target   (ChemicalCompound)
        defines the domain-specific interface that Client uses.
 
    Adapter   (Compound)
        adapts the interface Adaptee to the Target interface.
    
    Adaptee   (ChemicalDatabank)
        defines an existing interface that needs adapting.
    
    Client   (AdapterApp)
        collaborates with objects conforming to the Target interface.


    OUTPUT:
    Compound: Unknown ------

    Compound: Water ------
     Formula: H20
     Weight : 18.015
     Melting Pt: 0
     Boiling Pt: 100

    Compound: Benzene ------
     Formula: C6H6
     Weight : 78.1134
     Melting Pt: 5.5
     Boiling Pt: 80.1

    Compound: Alcohol ------
     Formula: C2H6O2
     Weight : 46.0688
     Melting Pt: -114.1
     Boiling Pt: 78.3
    */

    /// <summary>
    /// Program startup class for Real-World 
    /// Adapter Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}