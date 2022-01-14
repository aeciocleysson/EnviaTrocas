using System;

namespace EnviaTrocas.Model
{
    public class Provider : BaseModel
    {
        public string Name { get; private set; }

        public Provider(string name)
        {
            Name = name;
        }

        public void Update(string name)
        {
            Name = name;
            UpdateAt = DateTime.Now;
        }

        public void Delete(int isDelete)
        {
            IsDelete = isDelete;
        }
    }
}
