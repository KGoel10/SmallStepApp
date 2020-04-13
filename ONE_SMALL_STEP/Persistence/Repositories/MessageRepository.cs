using ONE_SMALL_STEP.Core.Domain;
using ONE_SMALL_STEP.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Persistence.Repositories
{
    public class MessageRepository: Repository<Message>,IMessageRepository
    {
        public MessageRepository(OneSmallStepContext context)
    : base(context)
        {
        }


        public OneSmallStepContext OneSmallStepContext
        {
            get { return Context as OneSmallStepContext; }
        }
    }
}