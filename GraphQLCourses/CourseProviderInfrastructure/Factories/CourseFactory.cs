
using Azure.Core;
using CourseProviderInfrastructure.Data.Entities;
using CourseProviderInfrastructure.Models;
using Microsoft.Extensions.Logging;

namespace CourseProviderInfrastructure.Factories;

public static class CourseFactory
{
    private static readonly ILogger _logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger("CourseFactory");

    public static CourseEntity CreateCourse(CourseCreateRequest request)
    {
        return new CourseEntity
        {
            Id = Guid.NewGuid().ToString(),
            IsBestSeller = request.IsBestSeller,
            Image = request.Image,
            Title = request.Title,
            DescriptionTitle = request.DescriptionTitle,
            Description = request.Description,
            Author = request.Author,
            Price = request.Price,
            DiscountPrice = request.DiscountPrice,
            Hours = request.Hours,
            LikesProcent = request.LikesProcent,
            LikesInNumber = request.LikesInNumber,
            ArticelsNumber = request.ArticelsNumber,
            DownloadableResources = request.DownloadableResources,
            Category = request.Category == null ? null : new CategoryEntity
            {
                CategoryName = request.Category.CategoryName!.ToString(),
            },
            CourseSteps = request.CourseSteps?.Select(step => new CourseStepsEntity
            {
                StepTitle = step.StepTitle,
                StepDescription = step.StepDescription,
                StepNumber = step.StepNumber
            }).ToList(),
            LearningObjectives = request.LearningObjectives?.Select(objective => new LearningObjectiveEntity
            {
                Description = objective.Description
            }).ToList()
        };
    }

    public static CourseEntity UpdateCourse(CourseUpdateRequest request)
    {
        return new CourseEntity
        {
            Id = request.Id,
            IsBestSeller = request.IsBestSeller,
            Image = request.Image,
            Title = request.Title,
            DescriptionTitle = request.DescriptionTitle,
            Description = request.Description,
            Author = request.Author,
            Price = request.Price,
            DiscountPrice = request.DiscountPrice,
            Hours = request.Hours,
            LikesProcent = request.LikesProcent,
            LikesInNumber = request.LikesInNumber,
            ArticelsNumber = request.ArticelsNumber,
            DownloadableResources = request.DownloadableResources,
            Category = request.Category == null ? null : new CategoryEntity
            {
                CategoryName = request.Category.CategoryName!.ToString(),
            },
            CourseSteps = request.CourseSteps?.Select(step => new CourseStepsEntity
            {
                StepTitle = step.StepTitle,
                StepDescription = step.StepDescription,
                StepNumber = step.StepNumber
            }).ToList(),
            LearningObjectives = request.LearningObjectives?.Select(objective => new LearningObjectiveEntity
            {
                Description = objective.Description
            }).ToList()
        };
    }

    public static Course CreateCourse(CourseEntity entity)
    {
        return new Course
        {
            Id = entity.Id,
            IsBestSeller = entity.IsBestSeller,
            Image = entity.Image,
            Title = entity.Title,
            DescriptionTitle = entity.DescriptionTitle,
            Description = entity.Description,
            Author = entity.Author,
            Price = entity.Price,
            DiscountPrice = entity.DiscountPrice,
            Hours = entity.Hours,
            LikesProcent = entity.LikesProcent,
            LikesInNumber = entity.LikesInNumber,
            ArticelsNumber = entity.ArticelsNumber,
            DownloadableResources = entity.DownloadableResources,
            Category = entity.Category == null ? null : new Category
            {
                CategoryName = entity.Category.CategoryName!.ToString(),
            },
            CourseSteps = entity.CourseSteps?.Select(step => new CourseSteps
            {
                StepTitle = step.StepTitle,
                StepDescription = step.StepDescription,
                StepNumber = step.StepNumber
            }).ToList(),
            LearningObjectives = entity.LearningObjectives?.Select(objective => new LearningObjective
            {
                Description = objective.Description
            }).ToList()
        };
    }

}
