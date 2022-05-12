using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void CommentRemove(Comment comment);
        //void CommentUpdate(Comment comment);
        List<Comment> GetAllComments(int id);
        //Comment GetCommentById(int id);
    }
}
