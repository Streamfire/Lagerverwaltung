namespace Lagerverwaltung.Core.Interfaces
{
    interface IBase
    {
        float Hoehe { get; set; }
        float Breite { get; set; }
        float Laenge { get; set; }

        float BerechneVolumen();
        float BerechneFlaeche();
    }
}