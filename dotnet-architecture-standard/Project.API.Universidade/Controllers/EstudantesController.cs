﻿using System;
using System.Web.Http;
using Project.API.Base.Controllers;
using Project.API.Base.MapperAdapters;
using Project.API.Universidade.Models.Estudante;
using Project.Domain.Universidade.Interfaces;
using Project.Models.Universidade.Entities;

namespace Project.API.Universidade.Controllers
{
    public class EstudantesController : GenericBaseApiControllerAsync
        <Guid, IEstudanteDomain, Estudante, EstudanteModel, EstudanteGetModel, EstudanteListItemModel, EstudantePostModel, EstudantePutModel>
    {
        #region - CONSTRUCTORS -

        public EstudantesController(IEstudanteDomain domain, IMapperAdapter mapperAdapter)
            : base(domain, mapperAdapter)
        {
        }

        #endregion

        #region - MAIN METHODS -

        [Authorize]
        public override IHttpActionResult Get()
        {
            return base.Get();
        }

        #endregion
    }
}