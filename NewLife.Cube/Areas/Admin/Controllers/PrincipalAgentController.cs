﻿using System;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using NewLife.Cube.Entity;
using XCode.Membership;

namespace NewLife.Cube.Cube.Controllers
{
    /// <summary>委托代理</summary>
    [Area("Cube")]
    [Menu(0, true, Icon = "fa-user-secret")]
    public class PrincipalAgentController : EntityController<PrincipalAgent>
    {
        static PrincipalAgentController() => LogOnChange = true;

        /// <summary>
        /// 添加页面初始化数据
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="type"></param>
        /// <param name="post"></param>
        /// <returns></returns>
        protected override Boolean Valid(PrincipalAgent entity, DataObjectMethodType type, Boolean post)
        {
            if (!post && type == DataObjectMethodType.Insert)
            {
                entity.Enable = true;
                entity.Times = 1;
                entity.Expire = DateTime.Now.AddMinutes(20);
            }

            return base.Valid(entity, type, post);
        }
    }
}