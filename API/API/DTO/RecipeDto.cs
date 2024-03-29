﻿namespace API.DTO
{
    public class RecipeDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public bool IsActive { get; set; }
        public List<IngredientDto> Ingredients { get; set; } = new();
        public List<InstructiontDto> Instructions { get; set; } = new();
        public List<RecipeCategoryDto> RecipeCategories { get; set; } = new();
    }
}
