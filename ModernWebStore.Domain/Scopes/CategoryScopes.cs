using ModernWebStore.Domain.Entities;
using ModernWebStore.SharedKernel.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.Domain.Scopes
{
    public static class CategoryScopes
    {
        public static bool CreateCategoryScopeIsValid(this Category category)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                AssertionConcern.AssertNotEmpty(category.Title, "O título é obrigatório"),
                AssertionConcern.AssertLength(category.Title, 3, 20, "Tamanho em caracteres inválido")                
                );
        }

        public static bool UpdateCategoryScopeIsValid(this Category category, string title)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                AssertionConcern.AssertNotEmpty(category.Title, "O título é obrigatório"),
                AssertionConcern.AssertLength(category.Title, 3, 20, "Tamanho em caracteres inválido")
                );
        }
    }
}
