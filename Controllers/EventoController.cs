﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;


namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                    EventoId = 1,
                Local = "São Paulo",
                Tema = "Angular 11 e .NET 5",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "Foto.png"
                },
                new Evento(){
                    EventoId = 2,
                Local = "Belo Horizonte",
                Tema = "Angular e suas novidades",
                Lote = "2º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemUrl = "Foto.png"
                }
        };

        public EventoController()
        {            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {            
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {            
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {            
            return "Exemplo de Post.";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {            
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {            
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
