
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
                Due�oCAD due�oCAD = new Due�oCAD();
                Due�oCEN due�oCEN = new Due�oCEN();
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

                comidaCEN.Nuevo("Arroz moro", 3, "Comida cubana", "Bajo en calor�as");

                platoCEN.Nuevo("Plato especial", 3);

                menuCEN.Nuevo("Men� de la casa", 1);

                //anadir los productos Racha
                IngredienteCAD IngredienteCAD = new IngredienteCAD();
                IngredienteCEN IngredienteCEN = new IngredienteCEN();

                int IdCaja1 = cajaCEN.Nueva(DateTime.Today, 600, 200, 0, IdNegocio1, IdEncargado1);
                int IdCaja2 =cajaCEN.Nueva(DateTime.Today, 1450, 780, 0, IdNegocio2, IdEncargado2);

                int IdEmpresa1 = empresaCEN.Nueva("Muerde la Pasta", "CALLE MARIE CURIE 4, 28521  MADRID");
                int IdEmpresa2 = empresaCEN.Nueva("MANOMAR HOSTELERIA SL", "CALLE SAN JUDAS 73,30420 MURCIA");

                int IdNegocio1 = negocioCEN.Nuevo("Restaurante Alicante Plus", "Calle del Oso, 10", "Alicante", "00320", "Alicante", "España", IdEmpresa1);
                int IdNegocio2 = negocioCEN.Nuevo("Finca Santa Luzia", " Av. de Alicante, 38, BAJO", "San Juan", "03550", "Alicante", "España", IdEmpresa2);

                int IdPedido1 = pedidoCEN.Nuevo(RestGenNHibernate.Enumerated.Rest.EstadoPedidoEnum.comanda, DateTime.Today, IdCamarero1, IdMesa1, IdPago1);
                int IdPedido2 = pedidoCEN.Nuevo(RestGenNHibernate.Enumerated.Rest.EstadoPedidoEnum.preparado, DateTime.Today, IdCamarero2, IdMesa2, IdPago2);

                int IdCamarero1 = camareroCEN.Nuevo("00423371K", "NATALIA", "HERNANDEZ RUIZ", 655238754, IdNegocio1);
                int IdCamarero2 = camareroCEN.Nuevo("00235532Y", "JOSE", "ALONSO ROMERO", 612765496, IdNegocio2);

                int IdMesa1 = mesaCEN.Nuevo(6, IdNegocio1);
                int IdMesa2 = mesaCEN.Nuevo(2, IdNegocio2);

                int IdPago1 = pagoCEN.Nuevo(50);
                int IdPago2 = pagoCEN.Nuevo(20);

                int Cliente1 = clienteCEN.Nuevo("00739100H", "ANDRES", "GIL MORALES");
                int Cliente2 = clienteCEN.Nuevo("00238754D", "SERGIO", "TORRES RAMOS");

                int IdFactura1 = facturaCEN.Nueva( DateTime.Today, 50, "2 Menus del dia ", Cliente1, IdPedido1);
                int IdFactura2 = facturaCEN.Nueva( DateTime.Today, 20, "1 Entrecot, 1 Pan , 1 Bebida, 1 Cafe solo", Cliente2, IdPedido2);


                int IdCajero1 = cajeroCEN.Nuevo( "00523821F", "ANTONIO", "GARCIA LOPEZ", 623096743, IdNegocio1);
                int IdCajero2 =cajeroCEN.Nuevo( "00983671J", "SERGIO", "SANCHEZ PEREZ", 673497634, IdNegocio2);

                int IdCocinero1 = cocineroCEN.Nuevo( "66379423V", "SANTIAGO", "DELGADO RUIZ", 606432201, IdNegocio1);
                int IdCocinero2 = cocineroCEN.Nuevo( "15435576W", "DAVID", "ALONSO SERRANO", 665324412, IdNegocio2);

                int IdDueño1 = dueñoCEN.Nuevo(IdEmpresa1);
                int IdDueño2 = dueñoCEN.Nuevo(IdEmpresa2);

                int IdEncargado1 = encargadoCEN.Nuevo( "55126534X", "JUAN", "GARCIA MARTINEZ", 622324534, IdNegocio2);
                int IdEncargado2 = encargadoCEN.Nuevo( "66187122M", "MARIA", "PASCUAL DIEZ", 655434534, IdNegocio1);

                int IdIngrediente1 = IngredienteCEN.Nuevo(20, RestGenNHibernate.Enumerated.Rest.UnidadEnum.caja, IdNegocio1);
                int IdIngrediente2 = IngredienteCEN.Nuevo(170, RestGenNHibernate.Enumerated.Rest.UnidadEnum.botella, IdNegocio2);
                // falta LineaProveedor Proveedor Movimiento



                lineapedidoCEN.Nueva(pedidoId, 4);


                int idCamarero = camareroCEN.Nuevo();
                int idMesa = mesaCEN.Nuevo(4);

                int idNegocio = negocioCEN.Nuevo("Restaurante Alicante Plus", "Calle del Oso, 10", "Alicante", "00320", "Alicante", "Espa�a", 10);
                int idEncargado = encargadoCEN.Nuevo();
                int idCaja = cajaCEN.Nuevo(DateTime.Today,1000.00,500.00,5.00,idNegocio,idEncargado);
                int pedidoId = pedidoCEN.Nuevo(RestGenNHibernate.Enumerated.Rest.EstadoPedidoEnum.preparado, idCamarero, idMesa, DateTime.Today, idCaja);
                lineapedidoCEN.NuevaLineaMenu(pedidoId, 20);
                //cambio de prueba
                
            }
            catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
