using System;
using System.Collections.Generic;

public class Orden
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodeOrden { get; set; }
    public Cliente Cliente { get; set; }
    public Vendedor Vendedor { get; set; }
    public List<OrdenDetalle> ListaOrdenDetalle { get; set; }
    public double SubTotal { get; set; }
    public double Impuesto { get; set; }
    public double Total { get; set; }

    public Orden(int codigo, DateTime fecha, string numeroOrden, Cliente cliente, Vendedor vendedor)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeOrden = numeroOrden;
        Cliente = cliente;
        Vendedor = vendedor;
        ListaOrdenDetalle = new List<OrdenDetalle>();
    }

    public void AgregarProducto(Producto producto)
    {
        int cantidad = 1;

        int nuevoCodigo = ListaOrdenDetalle.Count + 1;
        
        OrdenDetalle o = new OrdenDetalle(1, 1, producto);
        ListaOrdenDetalle.Add(o);

        SubTotal += cantidad * producto.Precio;
        Impuesto = SubTotal * 0.15;
        Total = SubTotal + Impuesto;
    }
}