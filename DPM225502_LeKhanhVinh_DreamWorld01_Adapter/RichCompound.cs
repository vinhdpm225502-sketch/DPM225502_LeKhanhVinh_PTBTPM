using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_DreamWorld01_Adapter
{
    internal class RichCompound : Compound
    {
        private readonly ChemicalDatabank bank = new();
    // Constructor
    public RichCompound(Chemical chemical)
    {
        Chemical = chemical;
    }
    public override void Display()
    {
        // Adaptee request methods
        BoilingPoint = bank.GetCriticalPoint(Chemical, State.Boiling);
        MeltingPoint = bank.GetCriticalPoint(Chemical, State.Melting);
        MolecularWeight = bank.GetMolecularWeight(Chemical);
        MolecularFormula = bank.GetMolecularStructure(Chemical);
        Console.WriteLine($"\nCompound: { Chemical} ------ ");
        Console.WriteLine($" Formula: {MolecularFormula}");
        Console.WriteLine($" Weight : {MolecularWeight}");
        Console.WriteLine($" Melting Pt: {MeltingPoint}");
        Console.WriteLine($" Boiling Pt: {BoilingPoint}");
    }
    }
}
