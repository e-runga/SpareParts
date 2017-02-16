using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.DataAccess
{
    public class AttachmentDal : BaseDal
    {
        #region .: Public Methods :.
        /// <summary>
        /// Gets the by product identifier.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public List<Attachment> GetByProductId(int productId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Attachment.Where(a => a.ProductId.Equals(productId)).ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Attachment GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Attachment.FirstOrDefault(a => a.Id.Equals(id));
                return retVal;
            }
        }

        /// <summary>
        /// Creates the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="extension">The extension.</param>
        /// <param name="mimeType">Type of the MIME.</param>
        /// <param name="content">The content.</param>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public Attachment Create(string fileName, string extension, string mimeType, byte[] content, int productId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                Attachment retVal = null;

                if (model.Product.Any(p => p.Equals(productId)))
                {
                    retVal = new Attachment
                    {
                        FileName = fileName,
                        Extension = extension,
                        MimeType = mimeType,
                        Content = content,
                        ProductId = productId
                    };

                    model.Attachment.AddObject(retVal);
                    model.SaveChanges();
                }

                return retVal;
            }
        }

        /// <summary>
        /// Saves the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="extension">The extension.</param>
        /// <param name="mimeType">Type of the MIME.</param>
        /// <param name="content">The content.</param>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public Attachment Save(int id, string fileName, string extension, string mimeType, byte[] content, int productId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var item = model.Attachment.FirstOrDefault(a => a.Id.Equals(id));

                if (item != null)
                {
                    item.FileName = fileName;
                    item.Extension = extension;
                    item.MimeType = mimeType;
                    item.Content = content;
                    item.ProductId = productId;

                    model.SaveChanges();
                }

                return item;
            }
        }
        #endregion
    }
}