namespace BUTTERFLYNAILSCENTERSw
{
    // DONE: Agregar propiedad de rol a los usuarios.
    // DONE: Boton para abrir el formulario de servicios.
    // DONE: A�adir metodos de pago.
    // DONE: A�adir formulario de citas.
    // DONE: A�adir formulario venta de servicios.
    // DONE: A�adir DateTime.Now donde haga falta.
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