<template>
	<el-row style="padding: 10px">
		<el-col :span="24" style="background-color: white; padding: 15px 0px; border-radius: 10px">
			<el-col :span="8" style="border-right: 2px dashed #dfe9f8">
				<div class="head-portrait">
					<div>
						<img :src="imgPath"/>
					</div>
					<div>
						<h5>{{ userInfo[0].UserAccount }}</h5>
					</div>
				</div>
			</el-col>
			<el-col :span="16" style="height: 80px">
				<div class="nav">
					<div @click="selectOrder(0)">
						<p>
							<svg
								t="1654532903297"
								class="icon"
								viewBox="0 0 1024 1024"
								version="1.1"
								xmlns="http://www.w3.org/2000/svg"
								p-id="4887"
								width="16"
								height="16"
								style="position: relative;top: 3.5px">
								<path
									d="M1024 223.328 1024 96.672C1024 43.36 980.928 0 928 0L96 0C43.072 0 0 43.36 0 96.672l0 126.624C0 276.64 43.072 320 96 320l0.512 0 0 513.984c0 36.224 30.048 65.696 67.008 65.696l335.808 0C551.328 974.688 637.984 1024 736 1024c158.816 0 288-129.184 288-288 0-84.768-37.024-160.864-95.488-213.6L928.512 319.936C981.184 319.68 1024 276.448 1024 223.328zM64 223.328 64 96.672C64 78.624 78.336 64 96 64l832 0c17.664 0 32 14.624 32 32.672l0 126.624C960 241.376 945.664 256 928 256L96 256C78.336 256 64 241.376 64 223.328zM960 736c0 123.712-100.288 224-224 224s-224-100.288-224-224 100.288-224 224-224c51.744 0 99.232 17.696 137.152 47.168 1.76 1.92 3.936 3.264 6.144 4.704C928.576 604.96 960 666.784 960 736zM736 448c-158.816 0-288 129.184-288 288 0 35.072 6.624 68.544 18.144 99.648L163.488 835.648c-1.952 0-3.008-1.184-3.008-1.696L160.48 323.712l704 0.864 0 154.08C825.76 459.2 782.208 448 736 448z"
									p-id="4888">
								</path>
								<path
									d="M768.256 576c0-17.696-14.304-32-32-32s-32 14.304-32 32l0 160c0 17.696 14.304 32 32 32l160 0c17.696 0 32-14.304 32-32s-14.304-32-32-32l-128 0L768.256 576z"
									p-id="4889">
								</path>
							</svg>
							待发货
						</p>
					</div>
					<div @click="selectOrder(1)">
						<p>
							<svg
								t="1654532428970"
								class="icon"
								viewBox="0 0 1109 1024"
								version="1.1"
								xmlns="http://www.w3.org/2000/svg"
								p-id="2236"
								width="16"
								height="16"
								style="position: relative;top: 3px">
								<path
									d="M341.333333 256v-42.666667h-85.333333V128h-42.666667v128h42.666667z"
									p-id="2237">
								</path>
								<path
									d="M925.866667 298.666667H746.666667v-21.333334c0-59.733333-46.933333-106.666667-106.666667-106.666666h-179.2C433.066667 72.533333 341.333333 0 234.666667 0 104.533333 0 0 104.533333 0 234.666667c0 83.2 42.666667 153.6 106.666667 196.266666V768c0 59.733333 46.933333 106.666667 106.666666 106.666667h21.333334c0 83.2 66.133333 149.333333 149.333333 149.333333s149.333333-66.133333 149.333333-149.333333h213.333334c0 83.2 66.133333 149.333333 149.333333 149.333333s149.333333-66.133333 149.333333-149.333333h64V503.466667L925.866667 298.666667zM1066.666667 576h-192c-36.266667 0-64-27.733333-64-64s27.733333-64 64-64h128l64 72.533333V576zM42.666667 234.666667c0-106.666667 85.333333-192 192-192s192 85.333333 192 192-85.333333 192-192 192-192-85.333333-192-192z m341.333333 746.666666c-59.733333 0-106.666667-46.933333-106.666667-106.666666s46.933333-106.666667 106.666667-106.666667 106.666667 46.933333 106.666667 106.666667-46.933333 106.666667-106.666667 106.666666z m142.933333-149.333333c-19.2-61.866667-74.666667-106.666667-142.933333-106.666667s-123.733333 44.8-142.933333 106.666667H213.333333c-36.266667 0-64-27.733333-64-64V452.266667c25.6 10.666667 55.466667 17.066667 85.333334 17.066666 130.133333 0 234.666667-104.533333 234.666666-234.666666 0-6.4 0-14.933333-2.133333-21.333334H640c36.266667 0 64 27.733333 64 64v554.666667h-177.066667zM896 981.333333c-59.733333 0-106.666667-46.933333-106.666667-106.666666s46.933333-106.666667 106.666667-106.666667 106.666667 46.933333 106.666667 106.666667-46.933333 106.666667-106.666667 106.666666z m142.933333-149.333333c-19.2-61.866667-74.666667-106.666667-142.933333-106.666667s-123.733333 44.8-142.933333 106.666667H746.666667V341.333333h162.133333l57.6 64H874.666667c-59.733333 0-106.666667 46.933333-106.666667 106.666667s46.933333 106.666667 106.666667 106.666667h192v213.333333h-27.733334z"
									p-id="2238">
								</path>
							</svg>
							运输中
						</p>
					</div>
					<div @click="selectOrder(2)">
						<p>
							<svg
								t="1654532589917"
								class="icon"
								viewBox="0 0 1024 1024"
								version="1.1"
								xmlns="http://www.w3.org/2000/svg"
								p-id="2517"
								width="16"
								height="16"
								style="position: relative;top: 3px">
								<path
									d="M808.43 626.155c98.827 0 178.943 80.115 178.943 178.944 0 98.827-80.115 178.943-178.943 178.943-98.828 0-178.943-80.115-178.943-178.943 0-98.83 80.114-178.944 178.943-178.944z m89.214 161.991v-68.533L782.761 822.049l-63.553-56.865v68.533l63.553 56.865 114.883-102.436z m82.689-428.38c0.222-5.029-1.346-9.555-4.885-13.314-1.181-3.436-3.041-6.657-6.143-8.905L515.741 15.98c-3.021-2.207-6.612-3.313-10.372-3.435L247.757 7.438c-8.191-0.159-15.498 4.986-18.055 12.746-2.532 7.716 0.226 16.212 6.882 20.911l117.699 83.433-56.196 40.637a18.582 18.582 0 0 0-5.861 2.693L44.864 346.164c-4.847 3.515-7.662 9.191-7.617 15.233v0.25l-1.248 0.607v313.358l7.883 15.111 453.543 321.568 0.754-0.365c0.816 0.615 1.53 1.264 2.45 1.795 2.716 1.351 5.635 2.047 8.571 2.047 3.782 0 7.497-1.143 10.703-3.477l111.296-78.909c-7.275-10.045-13.694-20.684-19.262-31.857L527.763 961.2V693.413l416.319-295.229v235.98a221.044 221.044 0 0 1 37.187 37.601l0.001-309.518c0-0.937-0.817-1.588-0.94-2.489zM307.217 45.668l191.679 3.886 399.758 283.423-191.679-3.799L307.217 45.669z m182.33 915.66L73.128 666.06V398.231L489.547 693.42v267.909zM509.213 660.1l202.332-145.923-421.578-298.983-202.343 145.92 421.59 298.987z m-78.398 53.457v145.105L113.414 633.594V488.448l317.401 225.108z"
									fill=""
									p-id="2518">
								</path>
							</svg>
							已收货
						</p>
					</div>
					<div @click="selectOrder(3)">
						<p>
							<svg
								t="1654533014519"
								class="icon"
								viewBox="0 0 1024 1024"
								version="1.1"
								xmlns="http://www.w3.org/2000/svg"
								p-id="6062"
								width="18"
								height="18"
								style="position: relative;top: 4px">
								<path
									d="M511.32513 66.181305c-245.449201 0-444.424952 198.99417-444.424952 444.442348 0 245.446132 198.97575 444.438255 444.424952 444.438255 245.445108 0 444.421882-198.992123 444.421882-444.438255C955.745988 265.174452 756.770238 66.181305 511.32513 66.181305M511.32513 910.319891c-220.738403 0-399.683958-178.961928-399.683958-399.697261S290.586726 110.923322 511.32513 110.923322c220.733287 0 399.680888 178.964998 399.680888 399.700331S732.058416 910.319891 511.32513 910.319891"
									p-id="6063">
								</path>
								<path
									d="M472.731136 679.414941c13.036921 0 23.611767-11.638061 23.611767-26.004257L496.342904 514.153036l169.474856 0.211824c4.070712 0 7.880481-0.909719 11.323906-2.449795 9.437953-3.390213 16.290011-13.07069 16.290011-24.608467L693.431677 339.172793c0-11.393491-6.712889-20.972661-16.010649-24.503067-3.496637-1.572822-7.42818-2.586918-11.604292-2.586918l-190.745299-0.261966c-0.417509 0-0.840134 0.105401-1.276063 0.122797-0.367367-0.017396-0.715291-0.122797-1.065262-0.122797-6.011924 0-11.447726 2.570545-15.624862 6.623861-0.245593 0.229221-0.490164 0.456395-0.735757 0.664126-0.208754 0.24457-0.453325 0.490164-0.664126 0.734734-4.054339 4.193509-6.621814 9.610892-6.621814 15.621792 0 0.350994 0.102331 0.701988 0.119727 1.068332-0.017396 0.435928-0.119727 0.854461-0.119727 1.293459l0 315.582515C449.0856 667.776879 459.675796 679.414941 472.731136 679.414941M496.342904 359.131357l149.830447 0.173962 0 30.882358-149.830447-0.227174L496.342904 359.131357zM496.342904 437.237249l149.830447 0.228197 0 29.622668-149.830447-0.210801L496.342904 437.237249z"
									p-id="6064">
								</path>
								<path
									d="M686.335049 702.311417 377.759111 702.311417c0.070608-0.753153 0.210801-1.469468 0.210801-2.238994L377.969912 476.0533c0-10.732435-6.290263-19.750833-15.011902-23.069415-3.931542-2.185782-8.547677-3.530406-13.528108-3.530406l-50.01716 0c-14.385639 0-26.007327 10.573823-26.007327 23.62814s11.621688 23.62814 26.007327 23.62814l34.06177 0 0 203.361641c0 0.769526 0.13917 1.484817 0.208754 2.238994l-27.054169 0c-13.528108 0-24.503067 9.959839-24.503067 22.249747 0 12.285814 10.974959 22.245653 24.503067 22.245653L686.335049 746.805794c13.527085 0 24.468275-9.959839 24.468275-22.245653C710.803323 712.271256 699.862133 702.311417 686.335049 702.311417"
									p-id="6065">
								</path>
								<path
									d="M334.539774 396.148435c4.613064 12.723789 17.739013 19.608593 29.274744 15.414061 11.533684-4.193509 17.160845-17.896602 12.548804-30.621415l-20.62269-54.700833c-4.650927-12.707416-17.759479-19.611663-29.29214-15.397688-11.570523 4.210905-17.163915 17.912975-12.548804 30.636764L334.539774 396.148435z"
									p-id="6066">
								</path>
								<path
									d="M666.253688 573.276598c6.764054-11.69025 3.619434-26.178219-7.04444-32.333406-10.623965-6.134721-24.747637-1.622964-31.491225 10.086729l-20.519336 30.619368c-0.524956 0.909719-0.592494 1.853208-0.978281 2.761903l-55.539944-43.729967c-10.366092-8.700149-25.168216-8.107655-33.06814 1.294482-7.900947 9.422603-5.906523 24.083511 4.472871 32.787754l127.811967 100.685143c10.360975 8.68787 25.146727 8.108678 33.06507-1.309832 7.900947-9.403161 5.89015-24.084535-4.455475-32.788777l-38.694277-30.478152c2.273786-1.922792 4.316306-4.193509 5.90857-6.958482L666.253688 573.276598z"
									p-id="6067">
								</path>
							</svg>
							退款/退货
						</p>
					</div>
				</div>
			</el-col>
		</el-col>
		<el-col :span="24" style="background-color: white; padding: 10px 0px; border-radius: 10px; margin-top: 10px">
			<div style="height: 390px; padding: 0px 10px; overflow: auto">
				<el-col :span="24" v-for="(item, index) in orderList" :key="item.OrderID" v-if="orderList !== false">
					<OrderItem :orderList="orderList[index]" style="margin-bottom: 5px"></OrderItem>
				</el-col>
				<el-col :span="24" v-if="orderList === false">
					<el-empty description="暂无订单" style="margin-top: 30px"></el-empty>
				</el-col>
			</div>
		</el-col>
	</el-row>
</template>

<script>
import axios from "axios";
import OrderItem from "@/components/User/Order/OrderItem";
import pubsub from "pubsub-js";

export default {
	name: "OrderManagement",
	components: {
		OrderItem
	},
	data() {
		return {
			userInfo: [],
			imgPath: "",
			orderList: [],
		}
	},
	methods: {
		getLocalTime(timeStamp) {
			timeStamp = timeStamp.replace(/[^0-9]/ig, "");
			return new Date(parseInt(Math.abs(timeStamp))).toLocaleString().replace(/:\d{1,2}$/, ' ');
		},
		selectOrder(status) {
			axios({
				url: "http://localhost:8080/demo/api/UserOrder/OrderInfo",
				method: "post",
				data: {
					userID: sessionStorage.getItem("userId"),
					statusCode: status,
				}
			}).then(
				response => {
					if (response.data !== false) {
						this.orderList = response.data;
						response.data.forEach((item) => {
							if (item.OrderStatus == 0) {
								item.OrderTime = this.getLocalTime(item.OrderTime);
							}
							if (item.OrderStatus == 1) {
								item.DeliverGoodsTime = this.getLocalTime(item.DeliverGoodsTime)
							}
							if (item.OrderStatus == 2) {
								item.ReceivingTime = this.getLocalTime(item.ReceivingTime);
							}
							if (item.OrderStatus == 3) {
								item.CancelTime = this.getLocalTime(item.CancelTime);
							}
						});
					} else {
						this.orderList = false;
					}
				},
				error => {
					this.$message.error("请求失败" + error.message);
				}
			)
		}
	},
	mounted() {
		axios.get(`http://localhost:8080/demo/api/UserOrder/UserInfo?userID=${sessionStorage.getItem("userId")}`).then(
			response => {
				if (response.data !== false) {
					this.userInfo = response.data;
					this.imgPath = "http://localhost:61124" + response.data[0].UserImg;
				} else {
					this.$message.error("用户信息获取失败");
				}
			},
			error => {
				this.$message.error("请求失败" + error.message);
			}
		);
		this.selectOrder(0);
	},
}
</script>

<style scoped>
.head-portrait {
	display: flex;
	justify-content: center;
}

.head-portrait > div:first-child {
	width: 80px;
	height: 80px;
	overflow: hidden;
	border-radius: 100%;
	border: 1px solid #ccc;
}

.head-portrait > div:first-child > img {
	width: 100%;
}

.head-portrait > div:last-child {
	margin-left: 15px;
	display: flex;
	justify-content: left;
	align-items: center;
}

.nav {
	margin-top: 20px;
	display: flex;
	justify-content: center;
	align-items: center;
}

.nav > div {
	padding: 10px 25px;
	border-right: 1px solid #e3edfc;
}

.nav > div > p {
	margin: 0px;
}

.nav > div:last-child {
	border: none;
}

.nav > div:hover {
	background-color: #F2F6FC;
}
</style>