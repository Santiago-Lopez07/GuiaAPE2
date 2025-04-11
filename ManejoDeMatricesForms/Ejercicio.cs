using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManejoDeMatricesForms
{
    public partial class formEjercicio : Form
    {
        private int[,] matriz;
        private int[,] matrizInvertida;

        public formEjercicio()
        {
            InitializeComponent();
            numFilas.Value = 3; // Inicializa el valor de filas en 0
            numColumnas.Value = 3; // Inicializa el valor de columnas en 0
        }

        private bool ValidarMatrizCreada()
        {
            if (matriz == null)
            {
                MessageBox.Show("Primero crea la matriz.");
                return false;
            }
            return true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int filas = (int)numFilas.Value;
                int columnas = (int)numColumnas.Value;

                // Verificar si el número de filas y columnas es válido
                if (filas <= 0 || columnas <= 0)
                {
                    MessageBox.Show("El número de filas y columnas debe ser mayor que 0.");
                    return;
                }

                matriz = new int[filas, columnas];
                dataGridMatriz.RowCount = filas;
                dataGridMatriz.ColumnCount = columnas;

                for (int i = 0; i < columnas; i++)
                    dataGridMatriz.Columns[i].HeaderText = $"Col {i}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la matriz: {ex.Message}");
            }
        }
        private void MostrarMatrizEnTexto(int[,] m)
        {
            int filas = m.GetLength(0);
            int columnas = m.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    txtSalida.AppendText($"{m[i, j]}\t");
                }
                txtSalida.AppendText(Environment.NewLine);
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (!ValidarMatrizCreada()) return;

            LeerDatosDesdeGrid();

            txtSalida.Clear();
            txtSalida.AppendText(Environment.NewLine + "Matriz Normal:" + Environment.NewLine);
            MostrarMatrizEnTexto(matriz);

            panelDibujo.Invalidate(); // Fuerza redibujar matriz original
        }
        private void LeerDatosDesdeGrid()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    int.TryParse(dataGridMatriz.Rows[i].Cells[j].Value?.ToString() ?? "0", out matriz[i, j]);
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            formPortada portadaForm = new formPortada(); // Crea una nueva instancia del formulario de la Portada
            portadaForm.Show(); // Muestra el formulario de la Portada
            this.Hide(); // Opcional: Oculta el formulario actual (formEjercicio)
                         // this.Close(); // Otra opción: Cierra completamente el formulario actual (formEjercicio)

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            matriz = null;
            matrizInvertida = null;

            dataGridMatriz.Rows.Clear();
            dataGridMatriz.Columns.Clear();
            txtSalida.Clear();
            lstResultados.Items.Clear();

            numFilas.Value = 3;
            numColumnas.Value = 3;

            panelDibujo.Invalidate();
            panelDibujoInvertida.Invalidate();
        }
        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            DibujarMatriz(matriz, e.Graphics);
        }
        private void DibujarMatriz(int[,] m, Graphics g)
        {
            if (m == null) return;

    int filas = m.GetLength(0);
    int columnas = m.GetLength(1);

    int anchoCelda = 40;
    int altoCelda = 40;

    Pen lapiz = Pens.Black;
    Font fuente = new Font("Arial", 12, FontStyle.Bold);

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            int x = j * anchoCelda;
            int y = i * altoCelda;

            Brush pincelTexto = Brushes.Black;

            if (filas == columnas)
            {
                if (i == j) pincelTexto = Brushes.Blue;
                if (j == columnas - 1 - i) pincelTexto = Brushes.Red;
            }

            g.DrawRectangle(lapiz, x, y, anchoCelda, altoCelda);

            string texto = m[i, j].ToString();
            SizeF textoSize = g.MeasureString(texto, fuente);
            float textoX = x + (anchoCelda - textoSize.Width) / 2;
            float textoY = y + (altoCelda - textoSize.Height) / 2;

            g.DrawString(texto, fuente, pincelTexto, textoX, textoY);
        }
    }
        }
        private void btnSimetria_Click(object sender, EventArgs e)
        {
            LeerDatosDesdeGrid();
            bool esSimetrica = VerificarSimetria(matriz);
            lstResultados.Items.Add(esSimetrica ? "✔ La matriz es simétrica." : "✘ La matriz NO es simétrica.");
        }
        private void MostrarDiagonalesEnLista(int[,] m, string etiqueta)
        {
            int n = m.GetLength(0);
            string diagPrincipal = "Diagonal Principal: ";
            string diagSecundaria = "Diagonal Secundaria: ";
            int sumaPrincipal = 0;
            int sumaSecundaria = 0;

            for (int i = 0; i < n; i++)
            {
                diagPrincipal += m[i, i] + " ";
                diagSecundaria += m[i, n - 1 - i] + " ";
                sumaPrincipal += m[i, i];
                sumaSecundaria += m[i, n - 1 - i];
            }

            lstResultados.Items.Add(diagPrincipal + $"→ Suma: {sumaPrincipal}");
            lstResultados.Items.Add(diagSecundaria + $"→ Suma: {sumaSecundaria}");
        }
        private void AgregarDiagonalesAlLista(int[,] m)
        {
            int n = m.GetLength(0);
            string diagPrincipal = "Diagonal Principal: ";
            string diagSecundaria = "Diagonal Secundaria: ";
            int sumaPrincipal = 0;
            int sumaSecundaria = 0;

            for (int i = 0; i < n; i++)
            {
                diagPrincipal += m[i, i] + " ";
                diagSecundaria += m[i, n - 1 - i] + " ";
                sumaPrincipal += m[i, i];
                sumaSecundaria += m[i, n - 1 - i];
            }

            diagPrincipal += $"→ Suma: {sumaPrincipal}";
            diagSecundaria += $"→ Suma: {sumaSecundaria}";

            lstResultados.Items.Add(diagPrincipal);
            lstResultados.Items.Add(diagSecundaria);
        }
        private void btnDiagonal_Click(object sender, EventArgs e)
        {
            LeerDatosDesdeGrid();

            if (matriz == null)
                return;

            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            lstResultados.Items.Clear();

            lstResultados.Items.Add("➤ Diagonales de la Matriz Original:");

            if (filas == columnas)
            {
                AgregarDiagonalesAlLista(matriz);
            }
            else
            {
                lstResultados.Items.Add("✘ La matriz original no es cuadrada.");
            }

            // Mostrar diagonales de la matriz invertida
            if (matrizInvertida != null)
            {
                lstResultados.Items.Add("");
                lstResultados.Items.Add("➤ Diagonales de la Matriz Invertida:");

                if (matrizInvertida.GetLength(0) == matrizInvertida.GetLength(1))
                {
                    AgregarDiagonalesAlLista(matrizInvertida);
                }
                else
                {
                    lstResultados.Items.Add("✘ La matriz invertida no es cuadrada.");
                }
            }
        }
        private void btnInvertir_Click(object sender, EventArgs e)
        {
            LeerDatosDesdeGrid();
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            matrizInvertida = new int[filas, columnas]; // GUARDAR la invertida

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizInvertida[i, j] = matriz[filas - 1 - i, columnas - 1 - j];
                }
            }

            txtSalida.AppendText(Environment.NewLine + "Matriz Invertida:" + Environment.NewLine);
            MostrarMatrizEnTexto(matrizInvertida);
            panelDibujoInvertida.Invalidate(); // redibujar el panel

        }
        private bool VerificarSimetria(int[,] m)
        {
            if (m.GetLength(0) != m.GetLength(1)) return false;

            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    if (m[i, j] != m[j, i]) return false;

            return true;
        }
        private void panelDibujoInvertida_Paint_1(object sender, PaintEventArgs e)
        {
            DibujarMatriz(matrizInvertida, e.Graphics);
        }
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            panelAyuda ayudaForm = new panelAyuda(); // Crear instancia del formulario de ayuda
            ayudaForm.Show();                        // Mostrar el formulario de ayuda
            this.Hide();                             // Ocultar el formulario actual (Form1)
        }
    }

}