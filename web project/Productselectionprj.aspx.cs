using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_project
{
    public partial class Productselectionprj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListid.Items.Add(new ListItem("select Products", "0"));
                DropDownListid.Items.Add(new ListItem("Mobile", "15000"));
                DropDownListid.Items.Add(new ListItem("Laptop", "50000"));
                DropDownListid.Items.Add(new ListItem("HeadPhones", "3000"));
            }
        }
        protected void ddlProduct_selectedindexchanged(object sender, EventArgs e)
        {
            if (DropDownListid.SelectedItem.Text == "Mobile")
            {
                Imageid.ImageUrl = "data:image/webp;base64,UklGRjgOAABXRUJQVlA4ICwOAACwXwCdASqYAQ8BPp1OokylpCMio5OZALATiWdu37OJz4ev6fH/1k8jDzPGukjczfyJ9H++m+JPzBx42N9//6HwV2Wjj/oHfx//VfyX0o4X/J42fl/f2miT088DM8Z4VjQdt9svTpw0RJdTIeFuXiyvbL06cNESXJrUW6WAnShwbZenThoiS5I6mE3enThoiPbw0RJcmtfeQtz6gh9QGH/C5Na+7oEuTWos7yu2/+pLZm3Umu9LumxndFPnekC0W5t5RrFFIqOH8EdJwl1pg7z6LrleIre/9MjcXCJsr/bc1vowjum3ovEImXtTXogaEqRY2AfeIj/YAZqzi2266zZcsY/zIfZlEELGuGg/k75N2kotzn8uhu/hwqkKMFj/12YCZDC+pUd/fzucDfbxfW8jMBAm1YUxmaaqizYtTXJorjY9Tog+GqPLtduQI3laL5ujHb/rQ9ZT0TxcZ/m+MmTbXv3n/BJe2JLey/aV3//9iAvfwNPw02L+IzhWPs48X//LklvNJJZM5QFrcCx0aPlpCE0pgXSCzz4Egmlb/V/91SG58OddbFTMZGL//HmwMOcdwaaCBL4gX5GgLYsdR//89aJ9pPoUyS/FSC/H+VVHYkbh590z7Zyiy+5guL3C55sRyzYh+Chv/8vqL1eDD13S8Ty7ndJtt54krUZJlKJ+8dsQaQpK+R3Sj/1d3oJc3ye6V9YklzQAVfMfmM7FcI2yqmtC7IAf1DhhQEhb9fmAkXa2fzJBYcpgNTA5VNfxHrnmvJgFPlcNe+/79+uylRCRvEP+F5GO8CVFvgr6ZiuOScHYyN3CrFcPkm3oF1LoG+htnv0Eo0sbIjSYdsRvkb9D13VvUrcuaq2fouaXKH2Blf/8WT5p4D433p09fXUdR8xXu6rmJEpGs8k5HCVIX3idcZ3B+Rg9C8/v//kdVfomDa1Y+QtztFj+VeI1/pw0RPXO+TWo89ZenThoiS9MZutRbn1BD6gh9QFufrmXw+hP1QHxGr9UZb5Moow1r85x392zP8lUsAAA/vasQ5Ejmwj/mtq7mcgLnB5tTb4VdH11ZeKZcz5q5s9jHk9jX1ISwxwihwDm2/ejEUOh0950WPku4DThwYUjvurHQsKDda24sU5BunuaPrNSEVsoNISOQjQlUfjnehRmRgYy0Olr7bQ/JPiIGV5CTMMUPsTfBddYgFbffUQii6YR8cdGAI7/nmhAmnPulr2FmuSN8kVbRL/eTC6VOoCPWaqWLNLnR5yCV7HrxHqoHY31+6Nt6q6QwYzQgRgMe9gwmH7pmFook7BFyGb9tTfahD26KGhOc+tEbaT9gR2p0fsoidgrjcOAhncX+aNyJUnTaQQvmBIF+CLbs6fzJc/A/YFCnoHqFt5LTvllDCGCPWN2QmuLDp36uVHA8nhEXDDparqvcsmjKLUUCrEw62lkNfJwH2apY2W2M63d8hP395RUG5OsVwjS+EHWpWBx0hELxjTEu9f04r2PLeh+wQXbvs+V6ijGhYrgruAogw/gP5sg/228TMtvRnNkmItsbZ59Yme1h0TQxG17Nvn7Y3j0xyTSpxHz/ZJ2wtbEgBfbwSrf9CjnwaPNWpxmAMnxlRJmyC3LYm5tW+j97au8nx7wyPYA9lmxH0z6Q1RRs0RY9MI+GXEkQY56SrGBZdvnFF7jImpkkNANFBCn6CghlwcVBjrtIeeJROncjOtnfDnpEK9Q2pEe0xGZSpkU9nBeNuXKawuBqOmcWxG9p85Whz7noJANDZQEFuxJkbL5veppUsnMCh+Wz6pd7ndvpQrjfH8KJk/K+C5sKV6wQzKL0VODqbmDT4hzEhA2umqEw0yHo080BPTLxXCpWNZp/SoOAomtY/9XkZczr4gc/5waupx2PvpJ2sJrTqk8Djk/naxEduXVRkNNORGVA3Fiem0k3Bjl72Xbn5j6jmbZgjSAr+8ih+2woId5hLjHKP2V8BlZL5TYEtBp8Sp+AY1ut4j3IV504lghT5BjnrVXL5uaZQX+fOsuhfhv9k4Mdu0ias20BLVAaFvEOTeigKeWjJSLvFJP/DuA/od7vIAVnIcpU7Qb4duHL+3EGr0puC+mQgpDYen9+XjQgxX3Me7o1t+Y0/EUZGQ+rFUx+lOT2B4WEfhvjpwU5zmb6RNmW3SU2LzoGaOuAikOSISrw/t2xpwkmAUsOa9lQlTU953KHzhNGayOexS4z2uZs92bZCcGpm8ULqNcejleZePOqkmehavpBaDj3//nBnCeJbhRwz5irB74YvZQuh+ihAcyMBLkC3AzihuAuhUyGES9m0oU/4L5lBxlMpLT3NtMMviaFSh7uOl9CEi9d/rCZY77NO375mepwcpOETVQx1PVnAtFPc0dxhjjV1M+/IeT6YpwBmO5n2BbBRZX81ypJ5soUOcWqPKL9dRDlpEOUrRgs9pJ07mzt6H3WgKp9TY6bGDHSoGk8LsNHOQo115Ells/TLuIi/GB5uwn2lsahrOTZCyHhdU8momqvJK6PZf7+Cue+USFD2nMLCaBVT+tBswCE6K+zh0bho1s1Snerg48LbFFmtd8RymVqS1UOByubcIm0zZJCNgSPirLkRSr+Y7AAKRghgRMUh45Ww6jWwuOIdhLgZXucPuGRnNY5gs2hW/IPkpXcJBCBPifcu049oD+DXryDPCJGJnVpdsjPH36Zjs0aajorcgCENoi9GtQHFXnZVuKmSIvJAzJzZRhZwCaGQQAMCzdJNEijmLJVdLkfgFbttbysaMHwRkaBw/tvljuycYbLz+BVn/ImXpbzFA2sqRGwyWZpiPP6w+uc2rvCth9yh00NaopRiSSpFiS/8lBA9fdOFvMgfisqWZymAamYl/v8Lfvf7aXwK51PC0uqvF8IWt7J0DqOfADtq7iQThWJf2sSp4c9FJXZoL8KEC+h/QmB5hLq7XvRlJJ3LpxinVwDi2wvtLQz3KWGs91BohxplKOzEj7iC+sryoA53oRa3mWXJLN6dL0nu9P7/RFjaCeXSAQFxgzjrAQo0bEDvpZNNdi1gelG0VHNywokMkF+huJO1a5TH/6kKG4oEez52QiKm6+jz16AGLAFCxAGEs51nryHdx1kg7zjbeb9XpmTLQFwOTbmwH9nm9JUXa/GQnHQpq7Pgxx2SFlKCiy4SFaRuvg9xcdk8QQHks+gYh6oPm+5ZGwgIpkhTmHLqw7eVa0x1JZKOi4V2r29pq1RyWu5NnXxDIyEZtkuRfFHskSRLU3AIRv01++cr9Qzu81bE3SX2dBOVKo4RqSVAHX0AHYD7jjuJfpAQZslntbiyNWbCJoyuld22i45Blm4XLClI3h6vSIEwMQLjxeaDvWVyvxqPFPikMFl48vaAg/hlq27K2A4aXdKS6KFG7jUx2H4i0Nad3cHTh/VVqNiUSGLAkyd+nPhUZcz+5y4oSYqpgVugb1Gk6UrEYAje4cdNrsrVIQ2BtTzYzfP0EQrwFg/L8QPfCVLfKqZ29awLr60F9ASxiog9sQKPhfXEZJZmNudRnCoq4Pzhc0dVaDNU9gyr7BgM6A4UGVWs7eCUIz69LOYUeyCEbJFjdRLhVDMwRw4M00nJBdsmp39b+mP9wZ8ynsGWgNSH9ahYpBDiM/erxl8n5VQnzJFzNoW4kwpssUCsaHGpOVglCXPW5UrB496IbKMNbraKlaslWxqpVSWPAyDTEQBf730taNOZu+/m5mhcwp0ttu5ereS5NFRDRrwqzKIXtU/8yq4AmQ9B0Ia4ldOeC6mxIN1Jxkpzo8x9EdiGMi6dSVd4eIRNnC8ObVqqzeoptaNmFAsMfZu1iNNTGRwrLPyPuhkSIFMov2INglcaCoaSm/L4Snw7S1/LIxRgCdibAb1PmimAY4qUHfeftCTQGABBiLPAGJvevzVjB1TnTJjpTeMHqp9AL/13g4+pgh5/Mo0XzKV6RAUIi6LbdOfc3HX5XAqcy8HZDd+4kd8QsDAsUNLYn3iARMjZ5XpjZFz2VryX9M+yt6Rev35TPNfuIGVWExMrpV2VywSMFy582+x0hZtbapG9szsgVXT6u3PZhmpyDWr/Wag8hZjU5KbBn2F7PJEArV/H/tk+tCvDI5T1BcAjfQEKgtTGmYdwPcUJTLtXmNNkejQi9UQj8+0jAAc28RhSnvWRr8/EVcN2gfOwrewyyqdkpZ6lDJ6cSiZC6cwni17NtBGQNY2wrRF9tR2t1ceCFGjICLKc4b6gHQLU6TlBJ6vIheZvQ/bBltcH01joIA7w0Tk8YWk4fuEPyYUK5X5HvsRbdgqrFCPCyywBO8624Ykb5RpzLJdIbLDTX5uWUkxltB1au0UCieOosbbozDB7NzNHKBYPxq7ZoSkhKcgnde1eJpHerlVnYh/Sqd6zrxRr5hneXc8GmtBmVpaAkHKTRy3t8EOJo54sb3EdJfnc7lh+O5kFp3nHR6UlIfXcsWOwjicP/rSwm0HaPU+UZPzHI5uHa5LuS5sFmx1W3JkzaasOBCXEJLa+NkM22ouOrOQmn4oD0g0QyLZsDGBflI8x4j/80x+Y5cE5NUUJ93vJVFRsPjT+VcyDt5DoYrJQb/IojY+8WKGuO21IVsa6D+LdXA3SfxJ0DaTb/LnC//oHMVe+YortCHqQ5m5LHMYwpWuSBoRgW9OPosOe5nl/QQT72H09pQ4HwzBABgCu6yddjHijOzjZ/ugv9i/AUvrYiKcnK51S0/otMUxVdW5l4sR90VOXUUZsTU7fOOixoEzYNVMDqAUrV5Cx7z/tO6eF74S/AAOZR4A9NNYC+4hgABKAmbbyYNZI8pgs09Bn5Ww2KV2CpFQQlF/BVSglj4FPHCywAQAAAA";
            }
            else if(DropDownListid.SelectedItem.Text=="Laptop")
            {
                Imageid.ImageUrl = "https://www.bing.com/th/id/OIP.r1flvYrSc0JNin8YtELQqwHaFI?w=253&h=211&c=8&rs=1&qlt=90&o=6&dpr=1.5&pid=3.1&rm=2";
            }
            else if (DropDownListid.SelectedItem.Text == "Headphones")
            {
                Imageid.ImageUrl = "https://www.bing.com/th/id/OIP.E2KzLGz3OADm2F2ssWuOOwHaE8?w=275&h=211&c=8&rs=1&qlt=90&o=6&dpr=1.5&pid=3.1&rm=2";
            }
            else
            {
                Imageid.ImageUrl = "";
                lblprice.Text = "";
            }
        }

        protected void btnPrice_Click(object sender, EventArgs e)
        {
            if (DropDownListid.SelectedIndex > 0)
            {
                lblprice.Text = "Price : " + DropDownListid.SelectedValue;
            }
            else
            {
                lblprice.Text = "Please select a Product";
            }
        }

        
    }
}