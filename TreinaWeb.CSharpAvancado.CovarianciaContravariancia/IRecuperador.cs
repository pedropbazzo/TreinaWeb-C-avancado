namespace TreinaWeb.CSharpAvancado.CovarianciaContravariancia
{
    public interface IRecuperador<out T>
    {
        T Recuperar(int index);
    }
}