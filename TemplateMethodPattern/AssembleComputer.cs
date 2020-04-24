using System;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 组装电脑
    /// </summary>
    public abstract class AssembleComputer
    {
        public string Brand { get; set; }
        public AssembleComputer(string brand)
        {
            Brand = brand;
        }
        /// <summary>
        /// 组装主机
        /// </summary>
        public abstract void BuildMainFramePart();

        /// <summary>
        /// 组装显示器
        /// </summary>
        public abstract void BuildScreenPart();

        /// <summary>
        /// 组装输入设备（键鼠）
        /// </summary>
        public abstract void BuildInputPart();

        /// <summary>
        /// 组装起来
        /// </summary>
        public virtual void Assemble()
        {
            BuildMainFramePart();
            BuildScreenPart();
            BuildInputPart();
        }

    }

    /// <summary>
    /// 组装HP电脑
    /// </summary>
    public class AssembleHpComputer : AssembleComputer
    {
        public AssembleHpComputer(string brandName) : base(brandName)
        {

        }
        public override void BuildMainFramePart()
        {
            Console.WriteLine($"组装{base.Brand}电脑的主板");
        }

        public override void BuildScreenPart()
        {
            Console.WriteLine($"组装{base.Brand}电脑的显示器");
        }

        public override void BuildInputPart()
        {
            Console.WriteLine($"组装{base.Brand}电脑的键盘鼠标");
        }
    }

    /// <summary>
    /// 组装Dell电脑
    /// </summary>
    public class AssembleDellComputer : AssembleComputer
    {
        public AssembleDellComputer(string brandName) : base(brandName)
        {

        }
        public override void BuildMainFramePart()
        {
            Console.WriteLine($"组装{base.Brand}电脑的主板");
        }

        public override void BuildScreenPart()
        {
            Console.WriteLine($"组装{base.Brand}电脑的显示器");
        }

        public override void BuildInputPart()
        {
            Console.WriteLine($"组装{base.Brand}电脑的键盘鼠标");
        }
    }


}
