using AutoMapper;
using LearnAutoMapper.Dtos;
using LearnAutoMapper.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnAutoMapper.Controllers;
[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
	private readonly IMapper _mapper;
	public BooksController(IMapper mapper)
	{
		_mapper = mapper;
	}

	List<Book> books = new()
	{
		new Book { Id = 1,Title="C#",Summary="bla bla",Author="Yazan",Price=25.6},
		new Book { Id = 2,Title="C++",Summary="bla bla",Author="Ali",Price=28.2},
		new Book { Id = 3,Title="C",Summary="bla bla",Author="Yara",Price=0},
	};


	//[HttpGet]
	/// <summary>
	/// /old way
	/// </summary>
	//public IActionResult GetAll() => Ok(books.Select(x => new BookDto { Id = x.Id, BookTitle = x.Title })); //etc

	[HttpGet]
	public IActionResult GetAll() => Ok(_mapper.Map<IEnumerable<BookDto>>(books));


	[HttpGet("{id}")]
	public IActionResult Details(int id)
	{
		var book = books.SingleOrDefault(x => x.Id == id);
		return Ok(_mapper.Map<BookDto>(book));
	}

	[HttpPost]
	public IActionResult Create(BookDto dto)
	{
		var book = _mapper.Map<Book>(dto);

		books.Add(book);

		return Ok(dto);
	}
}
