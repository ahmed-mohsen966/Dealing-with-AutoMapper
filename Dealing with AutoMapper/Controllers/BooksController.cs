using System.Runtime.CompilerServices;
using AutoMapper;
using Dealing_with_AutoMapper.DTOs;
using Dealing_with_AutoMapper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dealing_with_AutoMapper.Controllers
{
    [ApiController]
    [Route("api/[Controller]/[Action]")]
    public class BooksController : ControllerBase
    {
        private readonly IMapper _mapper;
        public BooksController(IMapper mapper)
        {
            _mapper = mapper;
        }
        List<Book> books = new()
        {
            new Book { ID = 1,Title="test title 1" , Summary = "summary 1" , Author = "author 1" , Price = 100.55},
            new Book { ID = 2,Title="test title 2" , Summary = "summary 2" , Author = "author 2" , Price = 150.55},
            new Book { ID = 3,Title="test title 3" , Summary = "summary 3" , Author = "author 3" , Price = 0}
        };
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<BookDto>>(books));
        }
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            var book = books.SingleOrDefault(b => b.ID == id);
            return Ok (_mapper.Map<BookDto>(book)); 
        }

        [HttpPost]
        public IActionResult Create(BookDto dto)
        {
            return Ok(_mapper.Map<Book>(dto));
        }
    }
}
