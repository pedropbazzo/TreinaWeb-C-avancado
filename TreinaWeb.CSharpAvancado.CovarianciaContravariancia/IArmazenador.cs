namespace TreinaWeb.CSharpAvancado.CovarianciaContravariancia
{
    public interface IArmazenador<in T>
    {
        void Armazenar(T objeto);
        
    }
}