﻿using Util.Ui.Angular;
using Util.Ui.Builders;
using Util.Ui.Configs;

namespace Util.Ui.Extensions {
    /// <summary>
    /// Angular扩展
    /// </summary>
    public static partial class Extensions {
        /// <summary>
        /// 添加NgFor指令
        /// </summary>
        /// <typeparam name="TBuilder">生成器类型</typeparam>
        /// <param name="builder">生成器实例</param>
        /// <param name="config">配置</param>
        public static TBuilder NgFor<TBuilder>( this TBuilder builder, IConfig config ) where TBuilder : TagBuilder {
            builder.AddAttribute( "*ngFor", config.GetValue( AngularConst.NgFor ) );
            return builder;
        }
    }
}