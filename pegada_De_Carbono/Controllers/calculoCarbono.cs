using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using pegada_De_Carbono.Entities;
using pegada_De_Carbono.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pegada_De_Carbono.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllHeaders")]
    public class calculoCarbono : Controller
    {

        [Route("result")]
        [HttpPost("result")]
        public addCarbono resultCarbono([FromBody] addCarbono obj)
        {
            Retorno retorno = new Retorno();
            DateTime Inicio = DateTime.UtcNow;
            addCarbono carbono = new addCarbono();
            try
            {

               double result =
                      obj.energiaCO2Mes * 0.295 +
                      obj.gasCozinhaCO2Mes * 35.893 +
                      obj.gasNaturalM3CO2Mes * 22.674 +
                      obj.tremCO2 * 0.058 +
                      obj.metroCO2 * 0.080 +
                      obj.motoGasolinaCO2 * 1.268 +
                      obj.motoEtanolCO2 * 0.7190001 +
                      obj.carroGasolinaPequenoCO2 * 2.184 +
                      obj.carroGasolinaMedioCO2 * 2.579 +
                      obj.carroGasolinaGrandeCO2 * 3.571 +
                      obj.carroEtanolPequenoCO2 * 0.7190001 +
                      obj.carroEtanolMedioCO2 * 0.7190001 +
                      obj.carroEtanolGrandeCO2 * 0.7190001 +
                      obj.carroDieselCO2 * 3.091 +
                      obj.onibusDieselCO2 * 0.11;

                carbono.energiaCO2Mes = obj.energiaCO2Mes * 0.295;
                carbono.gasCozinhaCO2Mes = obj.gasCozinhaCO2Mes * 35.893;
                carbono.gasNaturalM3CO2Mes = obj.gasNaturalM3CO2Mes * 22.674;
                carbono.tremCO2 = obj.tremCO2 * 0.058;
                carbono.metroCO2 = obj.metroCO2 * 0.080;
                carbono.motoGasolinaCO2 = obj.motoGasolinaCO2 * 1.268;
                carbono.motoEtanolCO2 = obj.motoEtanolCO2 * 0.7190001;
                carbono.carroGasolinaPequenoCO2 = obj.carroGasolinaPequenoCO2 * 2.184;
                carbono.carroGasolinaMedioCO2 = obj.carroGasolinaMedioCO2 * 2.579;
                carbono.carroGasolinaGrandeCO2 = obj.carroGasolinaGrandeCO2 * 3.571;
                carbono.carroEtanolPequenoCO2 = obj.carroEtanolPequenoCO2 * 0.7190001;
                carbono.carroEtanolMedioCO2 = obj.carroEtanolMedioCO2 * 0.7190001;
                carbono.carroEtanolGrandeCO2 = obj.carroEtanolGrandeCO2 * 0.7190001;
                carbono.carroDieselCO2 = obj.carroDieselCO2 * 3.091;
                carbono.onibusDieselCO2 = obj.onibusDieselCO2 * 0.11;
                carbono.valorTotal = result;
            }

            catch (Exception ex)
            {
                retorno.data = null;
                retorno.message = string.Format("Erro no serviço ({0}).", ex.Message);
                retorno.status = false;
            }
            finally
            {
                TimeSpan timeSpan = DateTime.UtcNow.Subtract(Inicio);

                retorno.datetime = DateTime.UtcNow.ToString("yyyyMMddHHmmss");
                retorno.duration = timeSpan.Milliseconds;
            }

            return carbono;
        }

        
    }
}
