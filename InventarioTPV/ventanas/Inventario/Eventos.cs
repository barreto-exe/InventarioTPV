﻿using static InventarioTPV.ArticuloEditar;

namespace InventarioTPV
{
    public partial class Inventario
    {
        private void BtnCrear_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ArticuloEditar ventana = new ArticuloEditar(Operacion.Agregar);
            ventana.Owner = this;
            ventana.ShowDialog();
        }

    }
}
