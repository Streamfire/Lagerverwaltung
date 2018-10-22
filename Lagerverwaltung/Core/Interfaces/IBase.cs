namespace Lagerverwaltung.Core.Interfaces
{
    interface IBase
    {
        float Höhe { get; set; }
        float Breite { get; set; }
        float Länge { get; set; }

        float BerechneVolumen();
        float BerechneFlaeche();
    }
}