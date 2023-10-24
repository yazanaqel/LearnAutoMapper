namespace LearnAutoMapper.Dtos;

public class BookDto
{
	public int Id { get; set; }
	public string BookTitle { get; set; } = string.Empty;
	public string Summary { get; set; } = string.Empty;
	public string Author { get; set; } = string.Empty;
	public double Price { get; set; }
	public bool IsFree { get; set; }
}
