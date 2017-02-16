using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpareParts.Logic
{
    public class AttachmentLogic : BaseLogic
    {
        #region .: Private Members :.
        /// <summary>
        /// The dal
        /// </summary>
        private readonly AttachmentDal dal;
        #endregion

        #region .: Constructors :.
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentLogic"/> class.
        /// </summary>
        public AttachmentLogic()
        {
            this.dal = new AttachmentDal();
        }
        #endregion

        #region .: Public Methods :.
        /// <summary>
        /// Gets the by product identifier.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public List<AttachmentDto> GetByProductId(int productId)
        {
            try
            {
                var retVal = this.dal.GetByProductId(productId).ToDto();
                return retVal;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public AttachmentDto GetById(int id)
        {
            try
            {
                var retVal = this.dal.GetById(id).ToDto();
                return retVal;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Creates the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">File name, extension and Content must be provided</exception>
        public AttachmentDto Create(AttachmentDto dto)
        {
            try
            {
                if (string.IsNullOrEmpty(dto.FileName) || string.IsNullOrEmpty(dto.Extension) || dto.Content.Length == 0)
                {
                    throw new ArgumentException("File name, extension and Content must be provided");
                }
                
                var retVal = this.dal.Create(dto.FileName, dto.Extension, dto.MimeType, dto.Content, dto.Product.Id).ToDto();
                return retVal;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Saves the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public AttachmentDto Save(AttachmentDto dto)
        {
            try
            {
                var retVal = this.dal.Save(dto.Id, dto.FileName, dto.Extension, dto.MimeType, dto.Content, dto.Product.Id).ToDto();
                return retVal;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}