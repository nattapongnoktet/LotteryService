using System.Text.Json.Serialization;

namespace LotteryService.Dto;

public class mResult
{
	public bool Success { get; set; }
	public dynamic? Result { get; set; } = null!;
	public string ErrorMessage { get; set; } = null!;
	public string TraceId { get; set; } = null!;
	public int StatusCode {get;set; }


	// Success:

	// return Ok() ← Http status code 200
	// return Created() ← Http status code 201
	// return NoContent(); ← Http status code 204

	// Client Error:

	// return BadRequest(); ← Http status code 400
	// return Unauthorized(); ← Http status code 401
	// return NotFound(); ← Http status code 404
}
