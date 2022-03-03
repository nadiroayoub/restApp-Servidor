
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using RestGenNHibernate.EN.Rest;
using RestGenNHibernate.CEN.Rest;
using RestGenNHibernate.CAD.Rest;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                BebidaCAD bebidaCAD = new BebidaCAD();
                BebidaCEN bebidaCEN = new BebidaCEN();
                CajaCAD cajaCAD = new CajaCAD();
                CajaCEN cajaCEN = new CajaCEN();
                CajeroCAD cajeroCAD = new CajeroCAD();
                CajeroCEN cajeroCEN = new CajeroCEN();
                CamareroCAD camareroCAD = new CamareroCAD();
                CamareroCEN camareroCEN = new CamareroCEN();
                ClienteCAD clienteCAD = new ClienteCAD();
                ClienteCEN clienteCEN = new ClienteCEN();
                CocineroCAD cocineroCAD = new CocineroCAD();
                CocineroCEN cocineroCEN = new CocineroCEN();
                ComidaCAD comidaCAD = new ComidaCAD();
                ComidaCEN comidaCEN = new ComidaCEN();
                DueñoCAD dueñoCAD = new DueñoCAD();
                DueñoCEN dueñoCEN = new DueñoCEN();
                EmpleadoCAD empleadoCAD = new EmpleadoCAD();
                EmpleadoCEN empleadoCEN = new EmpleadoCEN();
                EmpresaCAD empresaCAD = new EmpresaCAD();
                EmpresaCEN empresaCEN = new EmpresaCEN();
                EncargadoCAD encargadoCAD = new EncargadoCAD();
                EncargadoCEN encargadoCEN = new EncargadoCEN();
                FacturaCAD facturaCAD = new FacturaCAD();
                FacturaCEN facturaCEN = new FacturaCEN();
                LineaPedidoCAD lineapedidoCAD = new LineaPedidoCAD();
                LineaPedidoCEN lineapedidoCEN = new LineaPedidoCEN();
                //LineaProveedorCAD lineaproveedorCAD = new LineaProveedorCAD();
                //LineaProveedorCEN lineaproveedorCEN = new LineaProveedorCEN();
                MenuCAD menuCAD = new MenuCAD();
                MenuCEN menuCEN = new MenuCEN();
                MesaCAD mesaCAD = new MesaCAD();
                MesaCEN mesaCEN = new MesaCEN();
                MovimientoCAD movimientoCAD = new MovimientoCAD();
                MovimientoCEN movimientoCEN = new MovimientoCEN();
                NegocioCAD negocioCAD = new NegocioCAD();
                NegocioCEN negocioCEN = new NegocioCEN();
                PagoCAD pagoCAD = new PagoCAD();
                PagoCEN pagoCEN = new PagoCEN();
                PedidoCAD pedidoCAD = new PedidoCAD();
                PedidoCEN pedidoCEN = new PedidoCEN();
                PlatoCAD platoCAD = new PlatoCAD();
                PlatoCEN platoCEN = new PlatoCEN();
                PlatoIngredienteCAD platoingredienteCAD = new PlatoIngredienteCAD();
                PlatoIngredienteCEN platoingredienteCEN = new PlatoIngredienteCEN();
                ProveedorCAD proveedorCAD = new ProveedorCAD();
                ProveedorCEN proveedorCEN = new ProveedorCEN();
                RolCAD rolCAD = new RolCAD();
                RolCEN rolCEN = new RolCEN();
                ServicioCAD servicioCAD = new ServicioCAD();
                ServicioCEN servicioCEN = new ServicioCEN();
                TransacCreditCardCAD transaccreditcardCAD = new TransacCreditCardCAD();
                TransacCreditCardCEN transaccreditcardCEN = new TransacCreditCardCEN();
                TransacLineaCAD transaclineaCAD = new TransacLineaCAD();
                TransacLineaCEN transaclineaCEN = new TransacLineaCEN();

                bebidaCEN.Nuevo("Coca cola", 2,  RestGenNHibernate.Enumerated.Rest.TipoBebidaEnum.refresco, "Coca cola light");
                bebidaCEN.Nuevo("Coca cola", 1,  RestGenNHibernate.Enumerated.Rest.TipoBebidaEnum.refresco, "Coca cola normal");

                comidaCEN.Nuevo("Arroz moro", 3, "Comida cubana", "Bajo en calorías");

                platoCEN.Nuevo("Plato especial", 3);

                menuCEN.Nuevo("Menú de la casa", 1);

                int idCamarero = camareroCEN.Nuevo();
                int idMesa = mesaCEN.Nuevo(4);

                int idNegocio = negocioCEN.Nuevo("Restaurante Alicante Plus", "Calle del Oso, 10", "Alicante", "00320", "Alicante", "España", 10);
                int idEncargado = encargadoCEN.Nuevo();
                int idCaja = cajaCEN.Nuevo(DateTime.Today,1000.00,500.00,5.00,idNegocio,idEncargado);
                int pedidoId = pedidoCEN.Nuevo(RestGenNHibernate.Enumerated.Rest.EstadoPedidoEnum.preparado, idCamarero, idMesa, DateTime.Today, idCaja);
                lineapedidoCEN.NuevaLineaMenu(pedidoId, 20);

                
            }
            catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
