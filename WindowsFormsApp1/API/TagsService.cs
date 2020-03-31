using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.API
{
    public class TagsService
    {
        public Tags createTags(string name)
        {
                Tags tag = new Tags() { name = name };
                return tag;
        }

        public List<String> getTags()
        {
            List<String> tagNames = new List<string>();
            using (Model1Container context = new Model1Container())
            {
                context.TagsSet.ToList().ForEach(delegate (Tags tag) { tagNames.Add(tag.name); });
                return tagNames;
            }
        }

        public Tags saveTag(String name)
        {
            using (Model1Container context = new Model1Container())
            {
                Tags tag = createTags(name);
                context.TagsSet.Add(tag);
                context.SaveChanges();
                return tag;
            }
        }
    }
}
