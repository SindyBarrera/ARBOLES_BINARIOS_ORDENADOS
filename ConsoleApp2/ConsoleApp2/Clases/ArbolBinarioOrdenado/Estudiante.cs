


using System;
/**
*
* @author Sindy
*/
public class Estudiante : Comparador { //IMPLEMENTANDO LA INTERFAZ COMPARADOR
    //AL MOMENTO DE DCIRLE QUE IMPLEMENTARA LA CLASE COMPARADOR AUTOMATICAMENTE NOS PUSO LOS METODOS 

    //PROPIEDADES DEL ESTUDIANTE
    public string descripcion;
    public string nombre; //NOMBRE DEL ESTUDIANTE

    
    public bool mayorQue(object q)
    {
        //Casteando Estudiante 
        Estudiante p2 = (Estudiante)q; //Casteado de q 
        //Usamos compareTo >0 porque van a ser las letras que esten mas cercanas a la z 
        return nombre.CompareTo(p2.nombre) > 0;//COMPARANDO EL NOMBRE CON EL NOMBRE QUE ESTA RECORRIENDO EN EL OBJETO

    }
    public bool menorQue(object op2)
    {
        Estudiante p2 = (Estudiante)op2;
        //Usamos compareTo <0 van a ser lan letras que este mas cercanas a la a 
        return nombre.CompareTo(p2.nombre) < 0;//COMPARANDO EL NOMBRE
    }
    public bool mayorIgualQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return nombre.CompareTo(p2.nombre) >= 0;//COMPARANDO EL NOMBRE

    }
    public bool menorIgualQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return nombre.CompareTo(p2.nombre) <= 0;//COMPARANDO EL NOMBRE

    }
    public bool igualQue(object q)
    {
        //throw new System.NotImplementedException();
        return true;
    }



}
