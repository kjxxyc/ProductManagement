using AutoMapper;
using ProductManagement.BL.DTOs;
using ProductManagement.BL.InterfacesBL;
using ProductManagement.BL.Utilities;
using ProductManagement.BL.Validators;
using ProductManagement.DAL.EntitiesDAO;
using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.EntitiesBL
{
    public class ProductBL : IBaseBL<CreateProductDto, UpdateProductDto>
    {
        // Fields for mapping and DAO.
        private readonly ProductDAO _productDAO;

        private readonly IMapper _mapper;

        // Initialize constructor
        public ProductBL()
        {
            _productDAO = new ProductDAO();
            _mapper = AutoMapperConfig.Inicialize();
        }

        /// <summary>
        /// Create Product using validations.
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public OperationResultDto Create(CreateProductDto createDto)
        {
            // Definition of variables.
            var result = new OperationResultDto();
            var affectedRows = 0;
            var errorMessage = ValidateBeforeCreate(createDto);

            // Validate DTO
            if (string.IsNullOrEmpty(errorMessage))
            {
                // Map DTO to model
                var productModel = _mapper.Map<Product>(createDto);
                affectedRows = _productDAO.Create(productModel);

                result.Message = affectedRows > 0 ? "Creado con Exito." : "No se afectaron registros.";
                result.Success = affectedRows > 0;
                result.Result = productModel;
            }
            else
            {
                result.Message = errorMessage;
                result.Success = false;
            }

            return result;
        }

        public OperationResultDto Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public OperationResultDto FindById(int entityId)
        {
            throw new NotImplementedException();
        }

        public OperationResultDto Update(UpdateProductDto updateDto)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Business Intelligence validation before creating a Product.
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string ValidateBeforeCreate(CreateProductDto createDto)
        {
            // Definition of variables.
            var errorMessage = string.Empty;

            // Implementation of validations.
            var validator = new CreateProductValidator();

            var validationResult = validator.Validate(createDto);

            // Validation DTO.
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ToString(" \n ");
                return errorMessage;
            }
            // Valid unique code.
            if (_productDAO.CheckWithCondition(x => x.CodeProduct.ToLower() == createDto.CodeProduct.ToLower()))
            {
                errorMessage = $"El Código del Producto: {createDto.CodeProduct} ya existe.";
                return errorMessage;
            }

            return errorMessage;
        }

        public string ValidateBeforeDelete(int entityId)
        {
            throw new NotImplementedException();
        }

        public string ValidateBeforeUpdate(UpdateProductDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
