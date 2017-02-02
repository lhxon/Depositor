# 贷款分析器
## 运行环境
.net framework4.0 or above. 
## 功能说明
* `背景`  
  从某个机构，比如银行，P2P贷款，是日常生活中时有发生的事情，尤其是现在北京等地的房价很高，很多人买房都要贷款，常见的贷款方式有2种：
  * `等额本金`  
    每月还贷金额中本金是固定的，比如贷款30万，30年还清，第一个月大约偿还2100元，其中本金800多元，利息1200多元，以后每个月本金都是偿还这个数目，这种方法，产生的利息相比等额本息少一些。
  * `等额本息`  
     等额本息是指每月偿还的本息是固定的，同样贷款30万，30年还清，采取这种方式，每个月都偿还接近1600元，虽然每月比等额本金还贷少一些，但是还款周期中，产生的利息比等额本金多一些。
* `软件说明`
  * 支持功能  
    * 贷款配置；
    * 支持两种贷款方式下，计算已偿还和未偿还的贷款金额、本金金额、利息金额；
    * 贷款明细展示
      贷款明细按照月份，直至贷款结束日期，依次显示每个月的偿还贷款金额，本金，利息，利息率等数值显示，提供分页浏览显示功能。
    * 大额还款功能
      * 目前只提供一种大额还款的方法：缩短还款周期，每月偿还的本息还是按照未大额还款前；`将来还会扩展缩短还款金额，还款周期不变的方法`。
      * 支持输入计划大额还款金额，大额还款日期，显示大额还款后，每月最新的还款明细，包括本息，本金，利息，利息率等；
      * 柱状图显示，大额还款后，节省的利息等。
  * 软件开源  
  此软件完全开源，如需转载，请注明出处。  

## 软件架构说明
 * 分层结构
  Lib层（提供xml贷款配置本地保存服务等），业务模型层，业务逻辑层，界面层  
 * 主要对象介绍
   * Model层
     * MDebt（贷款模型基对象）implements IMRoot（模型根接口）
       * MEqualCaptial（等额本金模型对象，继承于MDebt对象）extends MDebt，implements IMDebt（贷款模型接口）
        * MEqualInterest（等额本息模型对象，继承于MDebt对象）extends MDebt，implements IMDebt（贷款模型接口）
   * 业务层
     * DebtAnalysis（提供贷款相关分析的业务逻辑）
     * BaseBigRepay（大额还款业务分析基类，之所以分离出这个对象，是因为大额还贷有多种方法）
        * ShortMonthsBigRepay（缩短周期大额还款基类）extends BaseBigRepay
          * ShortMonthsBigRepayS1（贷款方式为等额本金）extends ShortMonthsBigRepay ; implements IBigRepayDebt（大额还款接口）
          * ShortMonthsBigRepayS2（贷款方式为等额本息）extends ShortMonthsBigRepay;implements IBigRepayDebt（大额还款接口）
     
   * 界面层
     * BaseForm（页面的母版页，所有页面的根类）
       * BaseDlg（对话框的根类）
         * BaseSettingDlg（贷款配置基对话框）
         * DebtSettingDlg（贷款配置对话框）
         * DebtAnalysisDlg （贷款分析对话框）
         * DetailDebtDlg（贷款明细对话框）
       * StartPageForm （软件的启动界面）
       * MainForm（软件的主界面）
       
## 测试例子
* `问题描述`    
假定贷款金额30万，贷款时长30年，贷款方式为：等额本金，贷款年利率为4.9%，假定贷款起始日期为2015年10月，在如下配置界面完成对以上的参数配置。  
![贷款配置](/test/debtsetting.png)
* `结果分析`  
  软件贷款分析界面如下所示  
  ![贷款分析](/test/debtAnalysis.png)  
   结果：
  * `已还金额`
    * 本息：3.25万
    * 本金：1.33万
    * 利息：1.91万
    * 明细图（第一页）
    ![贷款分析](/test/detailPaid.png) 
  * `未还`  
    * 本息：48.86万
    * 本金：28.67万
    * 利息：20.19万  
    * 明细
    ![贷款分析](/test/detailUnpaid.png)  

  * `大额还贷`  
  * 填入计划还款日期，计划还贷金额后，点击计算，如下图所示：  
   ![大额还贷](/test/bigpay.png)      
  
  * 大额还贷后的明细表:  
  ![大额还贷明细](/test/detailUnpaid_bigPay.png)  
   
## 软件后期工作
  当前软件用.net C#写的，接下来会用Java再写一遍，进而过渡到手机移动app上。

## 建议
  希望小伙伴们提出修改意见，谢谢您！

