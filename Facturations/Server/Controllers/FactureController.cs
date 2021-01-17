using Facturations.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Facturations.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FactureController : ControllerBase
    {
        
        private readonly ILogger<FactureController> _logger;
        private readonly IBusinessData _data;

        public FactureController(ILogger<FactureController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
        {
            return _data.Factures;
        }

        [HttpGet("{reference}")]
        public ActionResult<Facture> Get(int reference)
        {
            var facture = _data.Factures.Where(fact => fact.Id == reference).FirstOrDefault();

            if(facture != null)
            {
                return facture;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Facture> Post([FromBody] Facture newFacture)
        {
            if(ModelState.IsValid)
            {
                // TODO : Ajouter la nouvelle
                return Created($"factures/{newFacture.Id}", newFacture);
            }
            else
            {
                return BadRequest(ModelState.Values);
            }
        }

    }
}
