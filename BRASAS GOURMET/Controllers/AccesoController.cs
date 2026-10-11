using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using BRASAS_GOURMET.Models;

namespace BRASAS_GOURMET.Controllers
{
    public class AccesoController : Controller
    {
        private readonly string _cadenaSqlite;

        public AccesoController(IConfiguration configuration)
        {
            _cadenaSqlite = configuration.GetConnectionString("CadenaSqlite");
            InicializarBaseDeDatos();
        }

        // Recrea la tabla limpia con los nombres correctos e inserta el usuario por defecto
        private void InicializarBaseDeDatos()
        {
            using (var conexion = new SqliteConnection(_cadenaSqlite))
            {
                conexion.Open();

                // Borra la tabla anterior si tenía columnas incorrectas y crea una nueva
                string dropQuery = "DROP TABLE IF EXISTS Usuarios;";
                using (var cmdDrop = new SqliteCommand(dropQuery, conexion))
                {
                    cmdDrop.ExecuteNonQuery();
                }

                string createTableQuery = "CREATE TABLE Usuarios (IdUsuario INTEGER PRIMARY KEY AUTOINCREMENT, Correo TEXT, Clave TEXT);";
                using (var cmdCreate = new SqliteCommand(createTableQuery, conexion))
                {
                    cmdCreate.ExecuteNonQuery();
                }

                // Inserta el usuario por defecto
                string insertQuery = "INSERT INTO Usuarios (Correo, Clave) VALUES ('admin@brasasgourmet.com', '123456');";
                using (var cmdInsert = new SqliteCommand(insertQuery, conexion))
                {
                    cmdInsert.ExecuteNonQuery();
                }
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string correo, string clave)
        {
            bool usuarioEncontrado = false;

            using (var conexion = new SqliteConnection(_cadenaSqlite))
            {
                conexion.Open();
                string query = "SELECT * FROM Usuarios WHERE Correo = @correo AND Clave = @clave";
                using (var comando = new SqliteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.Parameters.AddWithValue("@clave", clave);

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            usuarioEncontrado = true;
                        }
                    }
                }
            }

            if (usuarioEncontrado)
            {
                // Guarda la sesión y redirige al menú principal (Home/Index)
                HttpContext.Session.SetString("UsuarioLogueado", correo);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["Mensaje"] = "Correo o contraseña incorrectos";
                return View();
            }
        }

        public IActionResult Salir()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Acceso");
        }
    }
}