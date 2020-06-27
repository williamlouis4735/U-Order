#pragma checksum "E:\efcore\TinyShop\TinyShop\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a3e87919b28e9ff3871245786c3d5312fc1929f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\efcore\TinyShop\TinyShop\Views\_ViewImports.cshtml"
using TinyShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\efcore\TinyShop\TinyShop\Views\_ViewImports.cshtml"
using TinyShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3e87919b28e9ff3871245786c3d5312fc1929f", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a938c98b3d40fd576af9c4e906f7ced045ed9dc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a3e87919b28e9ff3871245786c3d5312fc1929f3517", async() => {
                WriteLiteral("\r\n    <title>浏览产品</title>\r\n    <meta charset=\"UTF-8\" />\r\n    <!-- import CSS -->\r\n    <link href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\"\r\n          rel=\"stylesheet\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a3e87919b28e9ff3871245786c3d5312fc1929f4683", async() => {
                WriteLiteral(@"
    <el-container id=""app"">
        <el-main>
            <el-row>
                <el-col>
                    <el-menu :default-active=""'全部'""
                             mode=""horizontal""
                             v-on:select=""onMenuItemSelect"">
                        <el-menu-item :index=""category""
                                      :key=""category""
                                      v-for=""(category,index) in categories"">
                            {{category}}
                        </el-menu-item>
                    </el-menu>
                </el-col>
            </el-row>
            <el-row>
                <el-col style=""padding: 10px;"">
                    <el-button type=""primary""
                               v-on:click=""onAddButtonClick"">
                        新增
                    </el-button>
                    <el-button v-bind:icon=""order==='asc'?'el-icon-caret-top':'el-icon-caret-botton'"" v-on:click=""onOrderButtonClick"">
                        按产品价");
                WriteLiteral(@"格{{order === 'asc' ? '升' : '降'}}序
                    </el-button>
                </el-col>
                <el-col :span=""16""
                        style=""padding: 10px;"">
                    <el-input :clearable=""true""
                              :span=""16""
                              placeholder=""请输入关键字""
                              v-model=""keyword"">
                        <el-button icon=""el-icon-search""
                                   slot=""append""
                                   v-on:click=""onSearchButtonClick"">

                        </el-button>
                    </el-input>
                </el-col>
            </el-row>
            <el-row>
                <el-col :span=""8""
                        style=""padding: 10px;""
                        v-for=""product in products"">
                    <el-card>
                        <div slot=""header"">
                            <span>{{product.productName}}</span>
                        </div>
                ");
                WriteLiteral(@"        <div>
                            <el-image src=""'/upload/' + product.ImgUrl""
                                      style=""height:300px;"">
                            </el-image>
                        </div>
                        <ul>产品序号：{{product.productNumber}}</ul>
                        <ul>产品类型：{{product.productType}}</ul>
                        <ul>产品价格：{{product.price}}</ul>
                        <div style=""text-align: right; border-top: #eeeeee solid 1px; padding-top: 20px; padding-bottom: 0"">
                            <el-button icon=""el-icon-edit""
                                       plain
                                       size=""mini""
                                       v-on:click=""onEditButtonClick(product.id)"">
                                编辑
                            </el-button>
                            <el-button icon=""el-icon-delete""
                                       plain
                                       size=""mini""
          ");
                WriteLiteral(@"                             type=""danger""
                                       v-on:click=""onDeleteButtonClick(product.id)"">
                                删除
                            </el-button>
                        </div>
                    </el-card>
                </el-col>
            </el-row>
        </el-main>
    </el-container>
    <!-- import Vue before Element -->
    <script src=""https://unpkg.com/vue/dist/vue.js""></script>
    <!-- import JavaScript -->
    <script src=""https://unpkg.com/element-ui/lib/index.js""></script>
    <script src=""https://cdn.bootcdn.net/ajax/libs/axios/0.19.2/axios.js""></script>
    <script>
        const app = new Vue({
            el: ""#app"",
            data: {
                // 获取到的所有产品数据放在这里（用于界面元素的绑定）
                products: [],
                keyword: '',
                order: 'asc',
                categories: ['全部', '电器', '数码', '食品']

            },
            methods: {
                async GetAllProducts(order) {");
                WriteLiteral(@"
                    // 获取所有产品数据
                    let response = await axios.get('/Product/GetAll', { params: { order: order } });

                    if (response.data.code === 'success') {
                        this.products = response.data.data;
                    } else {
                        this.$message({
                            message: '记录获取失败',
                            type: 'error'
                        });
                    }
                },
                onAddButtonClick() {
                    window.location.href = ""/Product/Create"";
                },
                onEditButtonClick(id) {
                    window.location.href = ""/Product/Edit/"" + id;
                },
                onOrderButtonClick() {
                    if (this.order === 'asc') {
                        this.order = 'desc';
                    } else {
                        this.order = 'asc';
                    }

                    this.GetAllProducts(this.");
                WriteLiteral(@"order);
                },
                onDeleteButtonClick(id) {
                    this.$confirm('确定删除该产品吗？',
                        '提示',
                        {
                            confirmButtonText: '确定',
                            cancelButtonText: '取消',
                            type: 'warning'
                        })
                        .then(async () => {
                            await this.deleteProduct(id);
                        })
                        .catch(() => { });;

                },
                async deleteProduct(id) {
                    let response = await axios.get('/Product/Delete/', { params: { id: id } });
                    if (response.data.code === 'success') {
                        this.$message({
                            type: 'success',
                            message: '删除记录成功！'
                        });
                        this.GetAllProducts(this.order);
                    } else {
              ");
                WriteLiteral(@"          this.$message({
                            message: '删除记录失败',
                            type: 'error'
                        });
                    }
                },
                async onSearchButtonClick() {
                    if (this.keyword === '') {
                        this.GetAllProducts(this.order);
                    } else {
                        this.GetAllProductsByKeyword(this.keyword);
                    }
                },
                async GetAllProductsByKeyword(keyword) {
                    let response = await axios.get('/Product/GetProductsByKeyword', { params: { keyword: keyword } });
                    if (response.data.code === 'success') {
                        this.products = response.data.data;
                    }

                },
                async GetAllProductsByCategory(category) {
                    let response = await axios.get('/Product/GetAllProductsByCategory', { params: { category: category } });

      ");
                WriteLiteral(@"              if (response.data.code === 'success') {
                        this.products = response.data.data;
                    }
                },
                onMenuItemSelect(index) {
                    if(index === '全部') {
                        this.GetAllProducts(this.order);
                    }else {
                        this.GetAllProductsByCategory(index);
                    }
                }
            },
            mounted() {
                this.GetAllProducts();
            }
        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591