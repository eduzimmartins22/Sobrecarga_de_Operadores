PK
     �!&Y             	 Sobrecarga_de_Operadores-main/UT f��fPK
    �!&Y}�Bw   �   ' 	 Sobrecarga_de_Operadores-main/README.mdUT f��fM�B1�w�H�����L�CmS���X��H�X����*7�}`O�_:+�([��fqLL�^�ip�BT��Aw�Y�V�BQj���d(��n��Q�Wf~������s&�%~?~PK  
     �!&Y             	              Sobrecarga_de_Operadores-main/UT f��fPK  
    �!&Y}�Bw   �   ' 	          E   Sobrecarga_de_Operadores-main/README.mdUT f��fPK      �   
  ( ccb73ecba6ee86e4a33b1c41f240f594e424eadeusing System;

class Ponto
{
    private float pontoX{get; set;}
    private float pontoY{get; set;}

public Ponto(float x = 0f, float y = 0f);


public string  mostrar()
{
    return "X = " + pontoX.ToString() + "Y = " + pontoY.ToString();

}
public Ponto operator +(Ponto p1 + Ponto p2)
{
    Ponto Result = new Ponto();
    Result.ponto pX = p1.pontoX + p2.pontoX;
    Result.ponto pY = p1.pontoY + p2.pontoY;
        return Result;
}
public Ponto operator -(Ponto p1 - Ponto p2)
{
    Ponto Resultado = new Ponto();
    Resultado.ponto pX = p1.pontoX - p2.pontoX;
    Resultado.ponto pY = p1.pontoY - p2.pontoY;
        return Resultado;
}

using System;
class Program
{
     static void Main()
    {
        Ponto p1 = new Ponto(15f, 3f);
        Ponto p2 = new Ponto(20f, 5f);
        Console.WriteLine("p1 = " + p1.mostrar());
        Console.WriteLine("");
        Console.WriteLine("p2 = " + p2.mostrar());

        p3 = p1 + p2;
        p4 = p1 - p2;

        Console.WriteLine("p3 = " + p3.mostrar());
        Console.WriteLine("");
        Console.WriteLine("p4 = " + p4.mostrar());
        Console.ReadLine();
    }
}