using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Structural
{
    /*
    Convert the interface of a class into another interface clients expect. 
    Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
        
    This structural code demonstrates the Adapter pattern which maps the interface 
    of one class onto another so that they can work together. These incompatible 
    classes may come from different libraries or frameworks.


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
    Called SpecificRequest()
    */

    /// <summary>
    /// MainApp startup class for Structural
    /// Adapter Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void MainStructural()
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
