using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// region
// 지역, 지방이라는 뜻
// 코드를 지역별로 깔끔하게 나누는 것을 의미
// 코드를 없애지 않고 숨겨주기만 한다.
// 특정 부분을 접는 역할

#region 레기온 시작
class Test
{
    string a;
    string b;
    string c;

}

#endregion


class Region
{
    #region 변수
    int num;
    string tt;
    float ss;
    #endregion
    #region 함수
    void QQ() { }
    void FF() { }
    #endregion
}