using System.Net;
using Assertiva.Domain.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EvaluationApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AssessmentController : ControllerBase
{
    

    private readonly ILogger<AssessmentController> _logger;

    public AssessmentController(ILogger<AssessmentController> logger)
    {
        _logger = logger;
    }

    [HttpPost("Assessment")]
    public void AddAssessment(AssessmentReqDto assessmentReqDto)
    {
        Console.WriteLine("log assessment");
        
        //verifyUser
        //Validate Payload
        //
        
    }
}
