namespace BUTTERFLYNAILSCENTERSw
{
    // DONE: Agregar propiedad de rol a los usuarios.
    // DONE: Boton para abrir el formulario de servicios.
    // DONE: Añadir metodos de pago.
    // DONE: Añadir formulario de citas.
    // DONE: Añadir formulario venta de servicios.
    // DONE: Añadir DateTime.Now donde haga falta.
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}