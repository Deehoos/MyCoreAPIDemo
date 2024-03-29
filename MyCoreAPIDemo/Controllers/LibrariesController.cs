﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCoreAPIDemo.Repository.Contract;

namespace MyCoreAPIDemo.Controllers
{
    [Route("api/Libraries")]
    [ApiController]
    public class LibrariesController : ControllerBase
    {
        private readonly ILibraryRepository<Author> _libraryRepository;

        public LibrariesController(ILibraryRepository<Author> libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        // GET: api/Libraries/GetAllAuthor
        [HttpGet]
        [Route("GetAllAuthor")]
        public IActionResult GetAllAuthor()
        {
            IEnumerable<Author> authors = _libraryRepository.GetAllAuthor();
            return Ok(authors);
        }

        // POST: api/Libraries/AddAuthor
        [HttpPost]
        [Route("AddAuthor")]
        public IActionResult AddAuthor()
        {

            return Ok();
        }

    }
}